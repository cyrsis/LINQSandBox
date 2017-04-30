using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace DemoOrder
{
    /// <summary>
    /// 排序化訂單
    /// </summary>
    public class OrderSerializer
    {
        private AddressBookDataContext abdc = new AddressBookDataContext();

        public OrderSerializer(AddressBookDataContext context)
        {
            this.abdc = context;
        }

        /// <summary>
        /// 排序化物件
        /// </summary>
        public static void Serializer(TabAddressBookEntity ab, string sfn)
        {
            if (ab == null)
                return;

            try
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(TabAddressBookEntity));
                StreamWriter sw = new StreamWriter(sfn);
                XmlWriter writer = XmlWriter.Create(sw);
                dcs.WriteObject(writer, ab);
                writer.Close();
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, " 匯出訂單出錯");
            }
        }

        /// <summary>
        /// 反排序化並附加物件
        /// </summary>
        public UnserializerResult Unserializer(string sfn)
        {
            if (File.Exists(sfn))
            {
                try
                {
                    DataContractSerializer dcs = new DataContractSerializer(typeof(TabAddressBookEntity));
                    StreamReader sr = new StreamReader(sfn);
                    XmlReader reader = XmlReader.Create(sr);
                    TabAddressBookEntity tb = dcs.ReadObject(reader, false) as TabAddressBookEntity;
                    sr.Close();
                    reader.Close();

                    if (tb == null)
                    {
                        MessageBox.Show("不是合法的訂單檔案", " 匯入訂單出錯");
                    }
                    else
                    {
                        return this.AppendOrder(tb);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, " 匯入訂單出錯");
                }
            }

            return null;
        }

        /// <summary>
        /// 增加或修改匯入的訂單
        /// </summary>
        private UnserializerResult AppendOrder(TabAddressBookEntity e)
        {
            TabAddressBookEntity entity;
            bool savechg = false;
            var query = this.abdc.TabAddressBook.Where(row => row.MainID == e.MainID);

            if (query.Count() == 1)
            {
                if (MessageBox.Show("匯入訂單編號已經存在，是否替換已經有的訂單？", "匯入訂單", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return null;

                //替換
                entity = query.First();
                //清除訂單
                entity.TabShoppingListEntity.Clear();
            }
            else
            {
                if (MessageBox.Show("匯入訂單不存在，如果要增加訂單，需要儲存當前資料，是否儲存資料？", "匯入訂單", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return null;

                savechg = true;
                entity = new TabAddressBookEntity();
                this.abdc.TabAddressBook.InsertOnSubmit(entity);
            }

            entity.Name = e.Name;
            entity.Sex = e.Sex;
            entity.TelphoneNumber = e.TelphoneNumber;
            entity.Address = e.Address;
            entity.Age = e.Age;
            entity.Company = e.Company;
            entity.Duty = e.Duty;

            //增加訂單
            foreach (var ord in e.TabShoppingListEntity)
            {
                TabShoppingListEntity lst = new TabShoppingListEntity();
                lst.Price = ord.Price;
                lst.Product = ord.Product;
                lst.Unit = ord.Unit;
                lst.Amount = ord.Amount;
                lst.Date = ord.Date;
                lst.TabAddressBook = entity;
            }

            if (savechg)
                this.abdc.SubmitChanges();

            return new UnserializerResult(entity, savechg);

        }
    }
}
