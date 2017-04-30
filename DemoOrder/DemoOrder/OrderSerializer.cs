using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace DemoOrder
{
    /// <summary>
    /// �ƧǤƭq��
    /// </summary>
    public class OrderSerializer
    {
        private AddressBookDataContext abdc = new AddressBookDataContext();

        public OrderSerializer(AddressBookDataContext context)
        {
            this.abdc = context;
        }

        /// <summary>
        /// �ƧǤƪ���
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
                MessageBox.Show(e.Message, " �ץX�q��X��");
            }
        }

        /// <summary>
        /// �ϱƧǤƨê��[����
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
                        MessageBox.Show("���O�X�k���q���ɮ�", " �פJ�q��X��");
                    }
                    else
                    {
                        return this.AppendOrder(tb);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, " �פJ�q��X��");
                }
            }

            return null;
        }

        /// <summary>
        /// �W�[�έק�פJ���q��
        /// </summary>
        private UnserializerResult AppendOrder(TabAddressBookEntity e)
        {
            TabAddressBookEntity entity;
            bool savechg = false;
            var query = this.abdc.TabAddressBook.Where(row => row.MainID == e.MainID);

            if (query.Count() == 1)
            {
                if (MessageBox.Show("�פJ�q��s���w�g�s�b�A�O�_�����w�g�����q��H", "�פJ�q��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return null;

                //����
                entity = query.First();
                //�M���q��
                entity.TabShoppingListEntity.Clear();
            }
            else
            {
                if (MessageBox.Show("�פJ�q�椣�s�b�A�p�G�n�W�[�q��A�ݭn�x�s��e��ơA�O�_�x�s��ơH", "�פJ�q��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

            //�W�[�q��
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
