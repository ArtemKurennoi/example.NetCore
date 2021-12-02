using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using FinalTask.Models.Entity;

namespace FinalTask.Models.Context
{
    public class ExamsContext : DbContext
    {
        // обязательно использовать конструктор
        public ExamsContext(DbContextOptions<ExamsContext> options)
            : base(options)
        {
        }

        // сконфигурировать EntityFramework
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // строка соединения с базой данных
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ExamDB;Trusted_Connection=True;");
        } // OnConfiguring


        // Таблицы БД
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }

        // инициализация
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasData(new Students[]
                {   
                    new Students { Id = 1, SurName = "Коралев", Name = "Иван", Patronymic = "Евгеньевич", Passport = "ВК864157", Year = 2002, Address = "ул. Мира, д. 1, кв. 42",            
                        Photo = "student1.jpg"},
                    new Students { Id = 2, SurName = "Викторов", Name = "Сергей", Patronymic = "Аркадьевич", Passport = "ВН214786", Year = 2003, Address = "ул. Мира, д. 51, кв. 5",         
                        Photo = "student2.jpg"},
                    new Students { Id = 3, SurName = "Комаров", Name = "Виктор", Patronymic = "Ярославович", Passport = "НЕ314796", Year = 2003, Address = "ул. Артема, д. 269, кв. 1",      
                        Photo = "student3.jpg"},
                    new Students { Id = 4, SurName = "Кружкин", Name = "Андрей", Patronymic = "Дмитриевич", Passport = "НК639852", Year = 2003, Address = "ул. Ватутина, д. 3б, кв. 24",     
                        Photo = "student4.jpg"},
                    new Students { Id = 5, SurName = "Легасов", Name = "Геннадий", Patronymic = "Генадьевич", Passport = "КН545821", Year = 2002, Address = "ул. Ленина, д. 28а, кв. 99",    
                        Photo = "student5.jpg"},
                    new Students { Id = 6, SurName = "Водянов", Name = "Олег", Patronymic = "Сергеевич", Passport = "АВ147852", Year = 2000, Address = "ул. Артема, д. 110, кв. 110",        
                        Photo = "student6.jpg"},
                    new Students { Id = 7, SurName = "Крамченко", Name = "Владимир", Patronymic = "Едуардович", Passport = "ДН963852", Year = 2002, Address = "ул. Ватутина, д. 150, кв. 1", 
                        Photo = "student7.jpg"},
                    new Students { Id = 8, SurName = "Каприн", Name = "Сергей", Patronymic = "Андреевич", Passport = "ВК789654", Year = 2001, Address = "ул. Щорса, д. 78, кв. 22",          
                        Photo = "student8.jpg"},
                    new Students { Id = 9, SurName = "Мавлен", Name = "Владислав", Patronymic = "Викторович", Passport = "МН657812", Year = 2001, Address = "ул. Мира, д. 124в, кв.34",      
                        Photo = "student9.jpg"},
                    new Students { Id = 10, SurName = "Купринов", Name = "Даниил", Patronymic = "Олегович,", Passport = "КР159753", Year = 2001, Address = "ул. Тельмана, д. 34, кв. 7",     
                        Photo = "student10.jpg"}
                });

            modelBuilder.Entity<Teachers>().HasData(new Teachers[]
                {
                    new Teachers {Id = 1, SurName = "Иванов", Name = "Иван", Patronymic = "Дмитриевич", ExamFee = 800,     Photo = "teacher1.jpg"},
                    new Teachers {Id = 2, SurName = "Петров", Name = "Евгений", Patronymic = "Генадьевич", ExamFee = 1000, Photo = "teacher2.jpg"},
                    new Teachers {Id = 3, SurName = "Ахметов", Name = "Виктор", Patronymic = "Сергеевич", ExamFee = 900,   Photo = "teacher3.jpg"},
                    new Teachers {Id = 4, SurName = "Черышев", Name = "Артем", Patronymic = "Сергеевич", ExamFee = 800,    Photo = "teacher4.jpg"},
                    new Teachers {Id = 5, SurName = "Дзюба", Name = "Владимир", Patronymic = "Сергеевич", ExamFee = 1000,  Photo = "teacher5.jpg"},
                    new Teachers {Id = 6, SurName = "Жирков", Name = "Андрей", Patronymic = "Викторович", ExamFee = 900,   Photo = "teacher6.jpg"},
                    new Teachers {Id = 7, SurName = "Павлов", Name = "Сергей", Patronymic = "Олегович", ExamFee = 500,     Photo = "teacher7.jpg"},
                    new Teachers {Id = 8, SurName = "Сереженко", Name = "Вадим", Patronymic = "Ярославович", ExamFee = 500,Photo = "teacher8.jpg"},
                    new Teachers {Id = 9, SurName = "Карасев", Name = "Камил", Patronymic = "Андреевич", ExamFee = 300,    Photo = "teacher9.jpg"},
                    new Teachers {Id = 10, SurName = "Басов", Name = "Дмитрий", Patronymic = "Дмитриевич", ExamFee = 400,  Photo = "teacher10.jpg"},
                });

            modelBuilder.Entity<Exams>().HasData(new Exams[]
            {
                new Exams{ Id = 1, DataExam = new DateTime(2021,11,24), DisciplineName =  "Математика", Score = 75, StudentId = 1, TeacherId = 1},
                new Exams{ Id = 2, DataExam = new DateTime(2021,11,29), DisciplineName =  "Математика", Score = 90, StudentId = 2, TeacherId = 1},
                new Exams{ Id = 3, DataExam = new DateTime(2021,11,07), DisciplineName =  "Литература", Score = 60, StudentId = 3, TeacherId = 2},
                new Exams{ Id = 4, DataExam = new DateTime(2021,11,09), DisciplineName =  "Литература", Score = 75, StudentId = 4, TeacherId = 2},
                new Exams{ Id = 5, DataExam = new DateTime(2021,11,07), DisciplineName =  "Физика", Score = 75, StudentId = 5, TeacherId = 3},
                new Exams{ Id = 6, DataExam = new DateTime(2021,11,09), DisciplineName =  "Физика", Score = 80, StudentId = 6, TeacherId = 3},
                new Exams{ Id = 7, DataExam = new DateTime(2021,11,11), DisciplineName =  "Право", Score = 80, StudentId = 7, TeacherId = 4},
                new Exams{ Id = 8, DataExam = new DateTime(2021,11,11), DisciplineName =  "Право", Score = 75, StudentId = 8, TeacherId = 4},
                new Exams{ Id = 9, DataExam = new DateTime(2021,11,12), DisciplineName =  "Английский язык", Score = 89, StudentId = 9, TeacherId = 5},
                new Exams{ Id = 10, DataExam = new DateTime(2021,11,14), DisciplineName = "Английский язык", Score = 74, StudentId = 10, TeacherId = 5},
                new Exams{ Id = 11, DataExam = new DateTime(2021,11,16), DisciplineName = "Русский язык", Score = 74, StudentId = 1, TeacherId = 6},
                new Exams{ Id = 12, DataExam = new DateTime(2021,11,18), DisciplineName = "Русский язык", Score = 90, StudentId = 2, TeacherId = 6},
                new Exams{ Id = 13, DataExam = new DateTime(2021,11,21), DisciplineName = "История", Score = 75, StudentId = 3, TeacherId = 7},
                new Exams{ Id = 14, DataExam = new DateTime(2021,11,22), DisciplineName = "Философия", Score = 80, StudentId = 4, TeacherId = 7},
                new Exams{ Id = 15, DataExam = new DateTime(2021,11,15), DisciplineName = "Физическая культура", Score = 94, StudentId = 5, TeacherId = 8},
                new Exams{ Id = 16, DataExam = new DateTime(2021,11,16), DisciplineName = "Физическая культура", Score = 91, StudentId = 6, TeacherId = 8},
                new Exams{ Id = 17, DataExam = new DateTime(2021,11,23), DisciplineName = "История", Score = 75, StudentId = 7, TeacherId = 9},
                new Exams{ Id = 18, DataExam = new DateTime(2021,11,23), DisciplineName = "Философия", Score = 80, StudentId = 8, TeacherId = 9},
                new Exams{ Id = 19, DataExam = new DateTime(2021,11,25), DisciplineName = "Физика", Score = 90, StudentId = 9, TeacherId = 10},
                new Exams{ Id = 20, DataExam = new DateTime(2021,11,28), DisciplineName = "Математика", Score = 74, StudentId = 10, TeacherId = 10},
            });
        }
    }
}
