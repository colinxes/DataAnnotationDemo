using System.Collections.Generic;
using System.Linq;
using DataAnnotationDemo.Mapper;
using DataAnnotationDemo.Models;
using DataAnnotationDemo.Repositories;
using DataAnnotationDemo.ViewModels;
using DevExpress.XtraEditors;

namespace DataAnnotationDemo
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object pSender, System.EventArgs pE)
        {
            List<Player> players = PlayerRepository.Instance.GetAllUsers().ToList();
            playerViewModelBindingSource.DataSource = UserMapper.Instance.Map<List<Player>, List<PlayerViewModel>>(players);
        }

        private void gridControlUser_DoubleClick(object pSender, System.EventArgs pE)
        {
            PlayerViewModel selectedPlayer = (PlayerViewModel)gridViewPlayer.GetFocusedRow();
            
            using (DataLayout<PlayerViewModel> layout = new DataLayout<PlayerViewModel>(selectedPlayer))
                layout.ShowDialog();
        }
    }
}
