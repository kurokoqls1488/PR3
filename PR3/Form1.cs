using Microsoft.EntityFrameworkCore;

namespace PR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // получение данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Partners.ToList();
                label1.Text = "Partners";
                foreach (User u in users)
                {
                    label2.Text += $"{u.Id} {u.IdPartner} {u.NamePartner}\n";
                }
            }
        }
        
    }
    public class User
    {
        public int Id { get; set; }
        public int? IdPartner { get; set; }
        public string? NamePartner { get; set; }

    }
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Partners { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PR2;Username=postgres;Password=1111");
        }

    }

}
