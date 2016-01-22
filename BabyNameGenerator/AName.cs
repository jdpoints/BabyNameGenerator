using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyNameGenerator
{
    class AName
    {
        public first_name FirstName { get; set; }
        public middle_name MiddleName { get; set; }
        public const String LastName = "Points";

        public AName()
        {
            this.RandomFirst();
            this.RandomMiddle();
        }

        public void RandomFirst()
        {
            first_name tempFirst = new first_name();

            if (this.FirstName == null)
            {
                tempFirst.FirstID = -1;
            }
            else
            {
                tempFirst = this.FirstName;
            }

            first_name newFirst = new first_name();

            using (var context = new NameGeneratorContext())
            {
                var nameQuery = context.first_name
                        .Where(n => n.Active != false)
                        .ToList();

                nameQuery.Shuffle();

                foreach (first_name qName in nameQuery)
                {
                    newFirst = qName;

                    if (newFirst.FirstID != tempFirst.FirstID)
                    {
                        this.FirstName = newFirst;
                        break;
                    }
                }
            }
        }

        public void RandomMiddle()
        {
            middle_name tempMiddle = new middle_name();

            if (this.MiddleName == null)
            {
                tempMiddle.MiddleID = -1;
            }
            else
            {
                tempMiddle = this.MiddleName;
            }

            middle_name newMiddle = new middle_name();

            using (var context = new NameGeneratorContext())
            {
                var nameQuery = context.middle_name
                        .Where(n => n.Active != false)
                        .ToList();

                nameQuery.Shuffle();

                foreach (middle_name qName in nameQuery)
                {
                    newMiddle = qName;

                    if (newMiddle.MiddleID != tempMiddle.MiddleID)
                    {
                        this.MiddleName = newMiddle;
                        break;
                    }
                }
            }
        }

        public void NewFirst()
        {
            first_name tempFirst = new first_name();

            if (this.FirstName == null)
            {
                tempFirst.FirstID = -1;
            }
            else
            {
                tempFirst = this.FirstName;
            }

            first_name newFirst = new first_name();

            using (var context = new NameGeneratorContext())
            {
                var nameQuery = context.first_name
                        .Where(n => n.Active != false)
                        .ToList();

                nameQuery.Shuffle();

                foreach (first_name qName in nameQuery)
                {
                    newFirst = qName;

                    var fullQuery = context.full_name
                       .Where(n => n.FirstID == newFirst.FirstID)
                       .Where(n => n.MiddleID == this.MiddleName.MiddleID)
                       .FirstOrDefault();

                    if (fullQuery == null
                        && newFirst.FirstID != tempFirst.FirstID)
                    {
                        this.FirstName = newFirst;
                        break;
                    }
                }
            }

            if (this.FirstName.FirstID == tempFirst.FirstID)
            {
                System.Windows.Forms.MessageBox.Show("All valid combinations with the current middle name have been tried. Please select a new middle name");
                this.RandomMiddle();
            }
        }

        public void NewMiddle()
        {
            middle_name tempMiddle = new middle_name();

            if (this.MiddleName == null)
            {
                tempMiddle.MiddleID = -1;
            }
            else
            {
                tempMiddle = this.MiddleName;
            }

            middle_name newMiddle = new middle_name();

            using (var context = new NameGeneratorContext())
            {
                var nameQuery = context.middle_name
                        .Where(n => n.Active != false)
                        .ToList();

                nameQuery.Shuffle();

                foreach (middle_name qName in nameQuery)
                {
                    newMiddle = qName;

                    var fullQuery = context.full_name
                       .Where(n => n.MiddleID == newMiddle.MiddleID)
                       .Where(n => n.FirstID == this.FirstName.FirstID)
                       .FirstOrDefault();

                    if (fullQuery == null
                        && newMiddle.MiddleID != tempMiddle.MiddleID)
                    {
                        this.MiddleName = newMiddle;
                        break;
                    }
                }
            }

            if (this.MiddleName.MiddleID == tempMiddle.MiddleID)
            {
                System.Windows.Forms.MessageBox.Show("All valid combinations with the current first name have been tried. Please select a new first name");
                this.RandomFirst();
            }
        }

        public static void RemoveFirst(int RemID)
        {
            first_name delFirst;

            using (var context = new NameGeneratorContext())
            {
                delFirst = context.first_name.Where(n => n.FirstID == RemID).First<first_name>();

                if (delFirst != null)
                {
                    delFirst.Active = false;
                }

                context.SaveChanges();
            }
        }

        public static void RemoveMiddle(int RemID)
        {
            middle_name delMiddle;

            using (var context = new NameGeneratorContext())
            {
                delMiddle = context.middle_name.Where(n => n.MiddleID == RemID).First<middle_name>();

                if (delMiddle != null)
                {
                    delMiddle.Active = false;
                }

                context.SaveChanges();
            }
        }

        public void WriteFull(bool IsGood)
        {
            full_name FullName = new full_name();

            FullName.FirstID = this.FirstName.FirstID;

            FullName.MiddleID = this.MiddleName.MiddleID;

            FullName.Good = IsGood;

            try
            {
                using (var context = new NameGeneratorContext())
                {
                    context.full_name.Add(FullName);
                    context.SaveChanges();
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("This name has already been entered. Please try another name combination.");
            }
        }
    }
}
