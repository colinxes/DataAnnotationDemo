using System.Collections.Generic;
using System.Linq;
using DataAnnotationDemo.Enums;
using DataAnnotationDemo.Mapper;
using DataAnnotationDemo.Models;
using DataAnnotationDemo.Repositories;
using DataAnnotationDemo.ViewModels;
using DevExpress.XtraEditors;

namespace DataAnnotationDemo.Forms
{
    public partial class MainForm : XtraForm
    {
        private enmEditFormType _editFormType;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events

        private void MainForm_Load(object pSender, System.EventArgs pE)
        {
            List<Player> players = PlayerRepository.Instance.GetAllUsers().ToList();
            playerViewModelBindingSource.DataSource = UserMapper.Instance.Map<List<Player>, List<PlayerViewModel>>(players);
            SetSwitchText();
        }

        private void gridControlUser_DoubleClick(object pSender, System.EventArgs pE)
        {
            PlayerViewModel selectedPlayer = (PlayerViewModel)gridViewPlayer.GetFocusedRow();
            EditingFormFactory.ShowEditForm(_editFormType, selectedPlayer);
        }

        private void toggleSwitchType_EditValueChanged(object pSender, System.EventArgs pE)
        {
            SetSwitchText();
        }

        #endregion

        #region Private methods

        private void SetSwitchText()
        {
            bool toggleSwitchValue = (bool)toggleSwitchType.EditValue;
            _editFormType = toggleSwitchValue ? enmEditFormType.Generic : enmEditFormType.Typed;
            layoutControlItemSwitch.Text = toggleSwitchValue ? "Generisch" : "Typisiert";
        }

        #endregion
    }
}
