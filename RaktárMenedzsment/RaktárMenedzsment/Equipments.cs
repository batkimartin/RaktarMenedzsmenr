using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment
{
    class Equipments
    {
        private MySqlConnection con = DataBaseConnectionSingleton.GetDatabaseConnectionInstance();
        public int equipmentId;
        public string equipmentName;
        public int equipmentQuantityInStock;


        public List<Equipments> GetEquipments()
        {
            List<Equipments> equipments = new List<Equipments>();            
            con.Open();
            using (var cmd = new MySqlCommand("Select * from Equipments", con))
            {
                using (var reader = cmd.ExecuteReader())
                {

                    Equipments equipment;
                    while (reader.Read())
                    {
                        equipment = new Equipments(reader.GetInt32("EquipmentId"), reader.GetString("EquipmentName"), reader.GetInt32("EquipmentQuantityInStock"));
                        equipments.Add(equipment);
                    }
                }
            }
            con.Close();
            return equipments;
        }

        public Equipments()
        {
        }

        public Equipments(int equipmentId, string equipmentName, int equipmentQuantityInStock)
        {
            this.equipmentId = equipmentId;
            this.equipmentName = equipmentName;
            this.equipmentQuantityInStock = equipmentQuantityInStock;
        }
    }
}
