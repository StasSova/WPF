using HW9_Resume_MVVM_INotify.ViewModel;
using HW9_Resume_MVVM_INotify.ViewModel.TEMPLATE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.Service
{
    public class GenerateDataService
    {
        public List<VM_Resume> resume;
        public GenerateDataService() 
        { 
            resume = new List<VM_Resume>();

            // создание резюме
            VM_Resume res1 = new VM_Resume();
            res1.Age = "21";
            res1.FullName = "Мария Жамбуле Колибе";
            res1.Post = "Директор";
            res1.Salary = "100 000 000";
            // первый контакт человека
            VM_Contact cont1 = new VM_Contact();
            cont1.Info = "+380661199510";
            // второй контакт человека
            VM_Contact cont2 = new VM_Contact();
            cont2.Info = "mari2003@gmail.com";
            // добавление к коллекции
            res1.Contacts.Add(cont1);
            res1.Contacts.Add(cont2);

            //добаляем первый язык 
            VM_Language lang1 = new VM_Language();
            lang1.Language = "EN";
            lang1.Level = 3; // от 1 до 5
            // добавляем второй язык
            VM_Language lang2 = new VM_Language();
            lang2.Language = "UK";
            lang2.Level = 5; // от 1 до 5

            // добавляем к колекциям
            res1.Languages.Add(lang1);
            res1.Languages.Add(lang2);


            //Профессиональные скилы:
            VM_Skill skill1 = new VM_Skill();
            skill1.SkillName = "Инстаграмм, FB, VK, OK, YouTube";
            VM_Skill skill2 = new VM_Skill();
            skill2.SkillName = "Photoshop, Illustrator, Lumyer";
            VM_Skill skill3 = new VM_Skill();
            skill3.SkillName = "RSS, Feedspy, RotaPost";
            res1.WorkSkills.Add(skill1);
            res1.WorkSkills.Add(skill2);
            res1.WorkSkills.Add(skill3);


            // Общие скилы
            VM_Skill skill4 = new VM_Skill();
            skill4.SkillName = "Коммуникабельность";
            VM_Skill skill5 = new VM_Skill();
            skill5.SkillName = "Ответственность";
            VM_Skill skill6 = new VM_Skill();
            skill6.SkillName = "Пунктуальность";
            res1.SocialSkills.Add(skill4);
            res1.SocialSkills.Add(skill5);
            res1.SocialSkills.Add(skill6);

            // Опыт работы
            VM_Job job1 = new VM_Job();
            job1.StartDate = "Июнь 2018";
            job1.EndDate = "Июль 2018";
            job1.Company = "Маркетинговое агенство";
            job1.Post = "СММ-специалист";
            job1.Description = "Ведение груп в соцсетях. Взаимодействие с коирайтерами. Подготовка размещения контента";
            res1.Jobs.Add(job1);


            VM_Resume res2 = new VM_Resume();
            res2.Age = "28";
            res2.FullName = "Александр Петров";
            res2.Post = "Разработчик";
            res2.Salary = "120 000";
            VM_Contact cont3 = new VM_Contact();
            cont3.Info = "+380501234567";
            VM_Contact cont4 = new VM_Contact();
            cont4.Info = "alex@example.com";
            res2.Contacts.Add(cont3);
            res2.Contacts.Add(cont4);

            VM_Language lang3 = new VM_Language();
            lang3.Language = "RU";
            lang3.Level = 4;
            VM_Language lang4 = new VM_Language();
            lang4.Language = "EN";
            lang4.Level = 2;
            res2.Languages.Add(lang3);
            res2.Languages.Add(lang4);

            VM_Skill skill7 = new VM_Skill();
            skill7.SkillName = "Java, Spring Boot";
            VM_Skill skill8 = new VM_Skill();
            skill8.SkillName = "RESTful API";
            VM_Skill skill9 = new VM_Skill();
            skill9.SkillName = "SQL, MongoDB";
            res2.WorkSkills.Add(skill7);
            res2.WorkSkills.Add(skill8);
            res2.WorkSkills.Add(skill9);

            VM_Skill skill10 = new VM_Skill();
            skill10.SkillName = "Teamwork";
            VM_Skill skill11 = new VM_Skill();
            skill11.SkillName = "Problem Solving";
            VM_Skill skill12 = new VM_Skill();
            skill12.SkillName = "Adaptability";
            res2.SocialSkills.Add(skill10);
            res2.SocialSkills.Add(skill11);
            res2.SocialSkills.Add(skill12);

            VM_Job job2 = new VM_Job();
            job2.StartDate = "Май 2015";
            job2.EndDate = "Декабрь 2017";
            job2.Company = "IT-компания";
            job2.Post = "Junior Developer";
            job2.Description = "Разработка и тестирование программного обеспечения. Поддержка и обновление существующих систем.";
            res2.Jobs.Add(job2);

            VM_Resume res3 = new VM_Resume();
            res3.Age = "25";
            res3.FullName = "Екатерина Сидорова";
            res3.Post = "Дизайнер";
            res3.Salary = "90 000";
            VM_Contact cont5 = new VM_Contact();
            cont5.Info = "+380731234567";
            VM_Contact cont6 = new VM_Contact();
            cont6.Info = "kat@example.com";
            res3.Contacts.Add(cont5);
            res3.Contacts.Add(cont6);

            VM_Language lang5 = new VM_Language();
            lang5.Language = "RU";
            lang5.Level = 5;
            VM_Language lang6 = new VM_Language();
            lang6.Language = "FR";
            lang6.Level = 3;
            res3.Languages.Add(lang5);
            res3.Languages.Add(lang6);

            VM_Skill skill13 = new VM_Skill();
            skill13.SkillName = "Adobe Photoshop";
            VM_Skill skill14 = new VM_Skill();
            skill14.SkillName = "Illustrator";
            VM_Skill skill15 = new VM_Skill();
            skill15.SkillName = "UI/UX Design";
            res3.WorkSkills.Add(skill13);
            res3.WorkSkills.Add(skill14);
            res3.WorkSkills.Add(skill15);

            VM_Skill skill16 = new VM_Skill();
            skill16.SkillName = "Creativity";
            VM_Skill skill17 = new VM_Skill();
            skill17.SkillName = "Attention to Detail";
            VM_Skill skill18 = new VM_Skill();
            skill18.SkillName = "Time Management";
            res3.SocialSkills.Add(skill16);
            res3.SocialSkills.Add(skill17);
            res3.SocialSkills.Add(skill18);

            VM_Job job3 = new VM_Job();
            job3.StartDate = "Январь 2016";
            job3.EndDate = "Сентябрь 2019";
            job3.Company = "Дизайн-студия";
            job3.Post = "Graphic Designer";
            job3.Description = "Разработка графических материалов для различных проектов. Создание макетов и дизайн-концепций.";
            res3.Jobs.Add(job3);

            VM_Resume res4 = new VM_Resume();
            res4.Age = "32";
            res4.FullName = "Иван Иванович Иванов";
            res4.Post = "HR-специалист";
            res4.Salary = "110 000";
            VM_Contact cont7 = new VM_Contact();
            cont7.Info = "+380501112233";
            VM_Contact cont8 = new VM_Contact();
            cont8.Info = "ivan@example.com";
            res4.Contacts.Add(cont7);
            res4.Contacts.Add(cont8);

            VM_Language lang7 = new VM_Language();
            lang7.Language = "EN";
            lang7.Level = 4;
            VM_Language lang8 = new VM_Language();
            lang8.Language = "ES";
            lang8.Level = 3;
            res4.Languages.Add(lang7);
            res4.Languages.Add(lang8);

            VM_Skill skill19 = new VM_Skill();
            skill19.SkillName = "Recruitment";
            VM_Skill skill20 = new VM_Skill();
            skill20.SkillName = "Employee Relations";
            VM_Skill skill21 = new VM_Skill();
            skill21.SkillName = "Interviewing";
            res4.WorkSkills.Add(skill19);
            res4.WorkSkills.Add(skill20);
            res4.WorkSkills.Add(skill21);

            VM_Skill skill22 = new VM_Skill();
            skill22.SkillName = "Communication";
            VM_Skill skill23 = new VM_Skill();
            skill23.SkillName = "Conflict Resolution";
            VM_Skill skill24 = new VM_Skill();
            skill24.SkillName = "Adaptability";
            res4.SocialSkills.Add(skill22);
            res4.SocialSkills.Add(skill23);
            res4.SocialSkills.Add(skill24);

            VM_Job job4 = new VM_Job();
            job4.StartDate = "Март 2014";
            job4.EndDate = "Ноябрь 2020";
            job4.Company = "HR Agency";
            job4.Post = "Senior HR Specialist";
            job4.Description = "Организация и проведение отбора персонала. Ведение переговоров с клиентами. Поддержка клиентов в вопросах кадрового учета.";
            res4.Jobs.Add(job4);
            

            resume.Add(res1);
            resume.Add(res2);
            resume.Add(res3);
            resume.Add(res4);
        }
    }
}
