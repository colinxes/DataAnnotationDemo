using System;
using System.Windows.Forms;

namespace DataAnnotationDemo.Forms
{
    public partial class GenericForm<T> : DevExpress.XtraEditors.XtraForm
    {
        private readonly T _object;

        public GenericForm(T pObject)
        {
            InitializeComponent();
            _object = pObject;
        }

        #region Events

        private void DataLayout_Load(object pSender, EventArgs pE)
        {
            InitDataLayout();
        }

        #endregion

        #region Private methods

        private void InitDataLayout()
        {
            dataLayoutControl.DataSource = new BindingSource() { DataSource = _object };
            dataLayoutControl.RetrieveFields();
        }

        #endregion
    }
}