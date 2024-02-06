namespace Desafio2
{
    public class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int idProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public int idVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }

        public ProductoVendido()
        {
            _id = 0;
            _idProducto = 0;
            _stock = 0;
            _idVenta = 0;
        }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;
        }




    }
}

