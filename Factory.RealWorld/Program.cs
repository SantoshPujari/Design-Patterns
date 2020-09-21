using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name);
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine("\t" + page.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    abstract class Page { }

    class SkillsPage : Page { }

    class EducationPage : Page { }

    class ExperiencePage : Page { }

    class IntroductionPage : Page { }

    class ResultsPage : Page { }

    class ConclusionPage : Page { }

    class SummaryPage : Page { }
    
    class BibliographyPage : Page { }

    abstract class Document
    {
        List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePage();
        }

        public abstract void CreatePage();

        public List<Page> Pages
        {
            get
            {
                return _pages;
            }
        }
    }

    class Resume : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    class Report : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
