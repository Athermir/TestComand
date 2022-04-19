using System;
using System.Windows;
using TestCommand.Model.Entities;

namespace TestCommand.Core
{
    public static class DbManager
    {
        public static void AddDepartment(string num, string name, string city)
        {
            try
            {
                using (var context = new PostavkiTovarEntities())
                {
                    context.D.Add(new D(num, name, city));
                    context.SaveChanges();
                }
                MessageBox.Show("Запись добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
    }
}
