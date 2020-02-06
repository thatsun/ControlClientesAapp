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
        public string peddio_modo_consulta = "Consultar";//Consultar, Editar, Confirmar, Produccion , Cancelar
        public string pedido_modocaptura = "Nuevo";//Nuevo,Editar

        public string id_seleccionado = "";
        public string id_pedidoseleccionado="";

        public static MiSerializador control;
        public int id_autoincrementado = 0;
        public int id_pedido_autoincremmentado = 0;

        public string fylename = "appdata01version20";
        public Dictionary<string, ClienteData> catalogo_clientes = new Dictionary<string, ClienteData>();

        public Dictionary<string, ProductoData> catalogo_productos = new Dictionary<string, ProductoData>();
        public Dictionary<string, PedidoData> catalogo_pedido=new Dictionary<string, PedidoData>();
        public MiSerializador()
        {
            control = this;
            LoadAppData();
            CreateProductList();
        }
        public void CreateProductList()
        {
            CreateProduct("1", "Paquete1", "Paquete 1 descripcion", Convert.ToDecimal(1000.0f));
            CreateProduct("2", "Paquete2", "Paquete 2 descripcion", Convert.ToDecimal(2000.0f));
            CreateProduct("3", "Paquete3", "Paquete 3 descripcion", Convert.ToDecimal(3000.0f));
            CreateProduct("4", "Paquete4", "Paquete 4 descripcion", Convert.ToDecimal(4000.0f));
            CreateProduct("5", "Paquete5", "Paquete 5 descripcion", Convert.ToDecimal(5000.0f));
            CreateProduct("6", "Paquete6", "Paquete 6 descripcion", Convert.ToDecimal(6000.0f));
            CreateProduct("7", "Paquete7", "Paquete 7 descripcion", Convert.ToDecimal(7000.0f));
            CreateProduct("8", "Paquete8", "Paquete 8 descripcion", Convert.ToDecimal(8000.0f));
        }
        public void CreateProduct(string _id, string _name,string _description, decimal _precio)
        {
            ProductoData _pdata = new ProductoData(_id,_name,_description,_precio);
            catalogo_productos.Add(_id, _pdata);

        }
        public void LoadAppData()
        {
            if (File.Exists(Application.LocalUserAppDataPath + "/" + "thisapp" + fylename + "094.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream my_file = File.Open(Application.LocalUserAppDataPath + "/" + "thisapp" + fylename + "094.dat", FileMode.Open);
                AppData my_data = (AppData)bf.Deserialize(my_file);


                catalogo_clientes = my_data.catalogo_clientes;
                catalogo_pedido = my_data.catalogo_pedido;
                id_autoincrementado = my_data.id_autoincrementado;
                id_pedido_autoincremmentado = my_data.id_pedido_autoincremmentado;

                my_file.Close();
                Debug.Print("datos app cargadas");
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(Application.LocalUserAppDataPath + "/" + "thisapp" + fylename + "094.dat");
                AppData data = new AppData();

                data.catalogo_clientes = catalogo_clientes;
                data.catalogo_pedido = catalogo_pedido;
                data.id_autoincrementado = id_autoincrementado;
                data.id_pedido_autoincremmentado = id_pedido_autoincremmentado;

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
            data.catalogo_pedido = catalogo_pedido;
            data.id_autoincrementado = id_autoincrementado;
            data.id_pedido_autoincremmentado = id_pedido_autoincremmentado;

            bf.Serialize(file, data);
            file.Close();
            Debug.Print("datos app guardadas");

        }
       
    }
    [Serializable]
    public class AppData
    {
        public int id_autoincrementado;
        public int id_pedido_autoincremmentado;
        public Dictionary<string, ClienteData> catalogo_clientes;
        public Dictionary<string, PedidoData> catalogo_pedido;
        public AppData()
        {
            id_autoincrementado = 0;
            catalogo_clientes = new Dictionary<string, ClienteData>();
        }
    }
    [Serializable]
    public class ClienteData
    {
        public string ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
    }
    [Serializable]
    public class PedidoData
    {
        public string PedidoID { get; set; }
        public string ClienteID { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }///pendiente,Confirmado,Produccion,Cancelado
        public bool Liqudiado { get; set; }
        public bool EnPagos { get; set; }
        public bool AnticipoPagado { get; set; }
        public decimal Importetotal { get; set; }
        public decimal Importepagado { get; set; }
        public decimal ImporteAnticipo { get; set; }
        public int CantidadPagos { get; set; }

        public int[] Fecha_de_pago_anticipo;
        public int[] FechaPedido;
        public int[] Fecha_para_liquidacion;

        public Dictionary<string, AbonoData> pedido_abonos;
        public Dictionary<int,ProductoData> pedido_productos;
        public PedidoData()
        {
            Estado = "pendiente";
            Liqudiado = false;
            EnPagos = false;
            FechaPedido = new int[3];
            Fecha_de_pago_anticipo = new int[3];
            Fecha_para_liquidacion = new int[3];
            pedido_abonos = new Dictionary<string, AbonoData>();
            pedido_productos = new Dictionary<int, ProductoData>();
        }
    }
    [Serializable]
    public class AbonoData
    {
        public string AbonoID { get; set; }
        public string PedidoID { get; set; }
        public string ClienteID { get; set; }
        public int[] Fecha_de_pago;
        public int[] Inicio_vigencia;        
        public string Estado { get; set; }///vencido, pagado, pendiente//vigente
        public decimal Importe { get; set; }


        public AbonoData() {
            Estado = "pendiente";
            Fecha_de_pago = new int[3];
            Inicio_vigencia = new int[3];


        }
    }
    [Serializable]
    public class ProductoData
    {
        public string id_product { get; set; }
        public string name_product { get; set; }
        public string desc_product { get; set; }
        public decimal precio { get; set; }
        public ProductoData(string _id, string _name, string _description, decimal _precio)
        {
            id_product = _id;

            name_product = _name;
            desc_product = _description;
            precio = _precio;
        }

        
    }
    
}
