using DataAnnotationDemo.ViewModels;

namespace DataAnnotationDemo
{
    public partial class TypedForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly PlayerViewModel _player;
        
        public TypedForm(PlayerViewModel pPlayer)
        {
            InitializeComponent();
            _player = pPlayer;
        }
        
        #region Events

        private void TypedForm_Load(object sender, System.EventArgs e)
        {
            playerViewModelBindingSource.DataSource = _player;
        }

        #endregion
    }
}