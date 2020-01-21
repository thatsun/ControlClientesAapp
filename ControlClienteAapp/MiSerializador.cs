using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlClienteAapp
{

    public class MiSerializador
    {
        public static MiSerializador control;
        public int id_autoincrementado = 0;

        public string fylename="appdata01";
        public Dictionary<int, ClienteData> catalogo_clientes = new Dictionary<int, ClienteData>();
        public MiSerializador()
        {
            control = this;
            LoadAppData();
        }
        public void LoadAppData()
        {
            if (File.Exists(Application.LocalUserAppDataPath + "/" + "thisapp" + fylename + "094.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream my_file = File.Open(Application.LocalUserAppDataPath + "/" + "thisapp" + fylename + "094.dat", FileMode.Open);
                AppData my_data = (AppData)bf.Deserialize(my_file);


                catalogo_clientes = my_data.catalogo_clientes;
                id_autoincrementado = my_data.id_autoincrementado;

                my_file.Close();
                Debug.Print("datos app cargadas");
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(Application.LocalUserAppDataPath + "/" + "thisapp" + fylename + "094.dat");
                AppData data = new AppData();

                data.catalogo_clientes = catalogo_clientes;
                data.id_autoincrementado = id_autoincrementado;

                bf.Serialize(file, data);
                file.Close();
                Debug.Print("datos app guardadas");
            }
        }
        public void SaveAppdata()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.LocalUserAppDataPath + "/" + "thisapp" + fylename + "094.dat");
            AppData data = new AppData();


            data.catalogo_clientes = catalogo_clientes;
            data.id_autoincrementado = id_autoincrementado;

            bf.Serialize(file, data);
            file.Close();
            Debug.Print("datos app guardadas");

        }
    }
    [Serializable]
    public class AppData
    {
        public int id_autoincrementado;
        public Dictionary<int, ClienteData> catalogo_clientes;
        public AppData()
        {
            id_autoincrementado = 0;
            catalogo_clientes = new Dictionary<int, ClienteData>();
        }
    }
    [Serializable]
    public class ClienteData
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
    }
}
