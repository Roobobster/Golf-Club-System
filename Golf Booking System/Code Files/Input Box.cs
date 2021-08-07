using System;
using System.Drawing;
using System.Windows.Forms;

namespace InputForms
{
    public static class InputBox
    {
        public static DialogResult CreateInputBox(string title, string promptText, ref string value)
        {
            //Decalres all the controls and the form for the Input Box Form.
            Form InputBoxForm = new Form();
            Label lblDisplayText = new Label();
            TextBox txtEnterBox = new TextBox();
            Button btnOK = new Button();
            Button btnCancel = new Button();

            //Sets The text for the form and it's controls
            InputBoxForm.Text = title;
            lblDisplayText.Text = promptText;
            txtEnterBox.Text = value;

            //Sets the text for the buttons
            btnOK.Text = "OK";
            btnCancel.Text = "Cancel";

            //Makes it so that the OK button sends a OK dialog result back to the form when it's clicked
            btnOK.DialogResult = DialogResult.OK;

            //Makes it so that the Cancel button sends a Cancel dialog result back to the form when it's clicked
            btnCancel.DialogResult = DialogResult.Cancel;

            //Sets the postition (x and y) and the height and width of the controls on this input box.
            lblDisplayText.SetBounds(9, 20, 372, 13);
            txtEnterBox.SetBounds(12, 36, 372, 20);
            btnOK.SetBounds(228, 72, 75, 23);
            btnCancel.SetBounds(309, 72, 75, 23);

            //Makes it so that the label gets auto scaled to fit the controls in it.
            lblDisplayText.AutoSize = true;
            txtEnterBox.Anchor = txtEnterBox.Anchor | AnchorStyles.Right;
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            //Sets the size of the input box form
            InputBoxForm.ClientSize = new Size(396, 107);

            //Adds the controls created above to the form
            InputBoxForm.Controls.AddRange(new Control[] { lblDisplayText, txtEnterBox, btnOK, btnCancel });

            InputBoxForm.ClientSize = new Size(Math.Max(300, lblDisplayText.Right + 10), InputBoxForm.ClientSize.Height);

        
            InputBoxForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            InputBoxForm.StartPosition = FormStartPosition.CenterScreen;

            //Makes it so that the form can't be minimized 
            InputBoxForm.MinimizeBox = false;
            InputBoxForm.MaximizeBox = false;

            //Makes the accept button on the form to the OK button, so when the enter key is pressed it will press the Enter button.
            InputBoxForm.AcceptButton = btnOK;
            //Makes the cancel button on the form to the Cancel button, so when esc is pressed it will press the cancel button.
            InputBoxForm.CancelButton = btnCancel;


            DialogResult dialogResult = InputBoxForm.ShowDialog();

            value = txtEnterBox.Text;

            return dialogResult;


        }
    }
}