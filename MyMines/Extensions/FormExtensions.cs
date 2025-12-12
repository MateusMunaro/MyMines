namespace MyMines.Extensions
{
    public static class FormExtensions
    {
        public static void ShowError(this Form form, string message, string title = "Erro")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(this Form form, string message, string title = "Aviso")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfo(this Form form, string message, string title = "Informação")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowSuccess(this Form form, string message, string title = "Sucesso")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Confirm(this Form form, string message, string title = "Confirmar")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static async Task ExecuteWithLoadingAsync(this Form form, Func<Task> action)
        {
            var originalCursor = form.Cursor;
            form.Cursor = Cursors.WaitCursor;
            form.Enabled = false;

            try
            {
                await action();
            }
            finally
            {
                form.Cursor = originalCursor;
                form.Enabled = true;
            }
        }
    }
}
