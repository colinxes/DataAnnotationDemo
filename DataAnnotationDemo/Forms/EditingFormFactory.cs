using System;
using DataAnnotationDemo.Enums;
using DataAnnotationDemo.ViewModels;

namespace DataAnnotationDemo.Forms
{
    public static class EditingFormFactory
    {
        public static void ShowEditForm(enmEditFormType pType, PlayerViewModel pPlayer)
        {
            switch (pType)
            {
                case enmEditFormType.Typed:
                    using (TypedForm form = new TypedForm(pPlayer))
                        form.ShowDialog();

                    break;
                case enmEditFormType.Generic:
                    using (GenericForm<PlayerViewModel> form = new GenericForm<PlayerViewModel>(pPlayer))
                        form.ShowDialog();

                    break;
                default:
                    throw new InvalidOperationException("Invalid parameters for the editing form.");
            }
        }
    }
}