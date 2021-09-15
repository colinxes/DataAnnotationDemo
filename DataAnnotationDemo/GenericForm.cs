using System;
using System.Windows.Forms;

namespace DataAnnotationDemo
{
    public partial class DataLayout<T> : DevExpress.XtraEditors.XtraForm
    {
        private readonly T _object;

        public DataLayout(T pObject)
        {
            _object = pObject;
            InitializeComponent();
        }

        private void DataLayout_Load(object pSender, EventArgs pE)
        {
            InitDataLayout();
        }

        private void InitDataLayout()
        {
            dataLayoutControl.DataSource = InitBindingSource();
            dataLayoutControl.RetrieveFields();
        }

        private BindingSource InitBindingSource()
        {
            return new BindingSource() { DataSource = _object };
        }
    }
}