using Microsoft.AspNetCore.Mvc;
using ScumvaluesMini.Models;
using System.Diagnostics;
using System.Text;
using static ScumvaluesMini.Models.ScrumValues;

namespace ScumvaluesMini.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            List<ScrumValues> va = new List<ScrumValues>();
            //Courage
            va.Add(new ScrumValues() { id = 1, name = " I work on the next highest priority Product Backlog Item (I do not cherry pick the work I pick up in the Sprint)", IsCheck = false });
            va.Add(new ScrumValues() { id = 2, name = " If I see something that is wrong with what I'm being asked to do, I will say so.", IsCheck = false });
            va.Add(new ScrumValues() { id = 3, name = " I will question & reproach my team members if I feel that they are doing something wrong.", IsCheck = false });
            va.Add(new ScrumValues() { id = 4, name = " Regardless of the person talking, I will correct them if I believe that they are incorrect.", IsCheck = false });
            va.Add(new ScrumValues() { id = 5, name = " I will stand firm if I believe I am right, even if I'm in the minority within the group.", IsCheck = false });
            //Commitment
            va.Add(new ScrumValues() { id = 6, name = " I always know what the sprint goal is and how my work supports it.", IsCheck = false });
            va.Add(new ScrumValues() { id = 7, name = " I do everything I can to ensure we achieve the goals of the sprint.", IsCheck = false });
            va.Add(new ScrumValues() { id = 8, name = " In my current team, I have never thought of taking a sick day to avoid going into work.", IsCheck = false });
            va.Add(new ScrumValues() { id = 9, name = " I always arrive on time for the events, my colleagues never have to wait for me to start the event.", IsCheck = false });
            va.Add(new ScrumValues() { id = 10, name = " I know what it means to say that an item is done, i.e. I know the criteria that meets our Definition of Done.", IsCheck = false });
            //Focus
            va.Add(new ScrumValues() { id = 11, name = " Whilst working on a story I do not get distracted.", IsCheck = false });
            va.Add(new ScrumValues() { id = 12, name = " If I am not enjoying the work in a story I still give it the attention it needs.", IsCheck = false });
            va.Add(new ScrumValues() { id = 13, name = " When enjoying working on a story I will not over work a story just to prolong it.", IsCheck = false });
            va.Add(new ScrumValues() { id = 14, name = " I do not procrastinate when working on a story.", IsCheck = false });
            va.Add(new ScrumValues() { id = 15, name = " As soon as the story is ready to move into a new state, I will tell my colleagues and either hand it over or ensure that they know it is ready to pick up.", IsCheck = false });
            //Openness
            va.Add(new ScrumValues() { id = 16, name = " I do not shy away from telling difficult news to team members and stakeholders", IsCheck = false });
            va.Add(new ScrumValues() { id = 17, name = " I do not hide away difficult issues in the hope that they will sort themselves out.", IsCheck = false });
            va.Add(new ScrumValues() { id = 18, name = " If something / someone is annoying me I will address it / tell them.", IsCheck = false });
            va.Add(new ScrumValues() { id = 19, name = " My colleagues can judge what state of mind I'm in, I can share my feelings with my them.", IsCheck = false });
            va.Add(new ScrumValues() { id = 20, name = " I always say the true state of an item, and do not over/under play it.", IsCheck = false });
            //Respect
            va.Add(new ScrumValues() { id = 21, name = " I listen with equal intensity regardless of who is talking.", IsCheck = false });
            va.Add(new ScrumValues() { id = 22, name = " When listening to people I never talk over them.", IsCheck = false });
            va.Add(new ScrumValues() { id = 23, name = " I value everyone's opinion equally.", IsCheck = false });
            va.Add(new ScrumValues() { id = 24, name = " I am never concerned who works on what item in the backlog.", IsCheck = false });
            va.Add(new ScrumValues() { id = 25, name = " I feel that my opinion is respected and that I have an equal say in the team.", IsCheck = false });
            

            ValuesList vaList = new ValuesList();
            vaList.values = va;
            SumScore(vaList);

            return View(vaList);

        }
        // thử cách khác:

        
        [HttpPost]
        public ActionResult Index(ValuesList val) 
        {
            SumScore(val);
            return View(val);
        }

        private void SumScore(ValuesList val)
        {
            var resultColection = new List<int>();
            var skip = 0;
            for (int i = 0; i <= 4; i++)
            {
                resultColection.Add(val.values.Skip(skip).Take(5).Count(x => x.IsCheck));
                skip = skip + 5;
            }
            val.Score = resultColection.ToArray();
        }


        public IActionResult Privacy(ValuesList val)
        {
            int t=3;
            int t1=4;
            int t2=2;
            int t3=3;
            int t4=2;

            //List<Values> vaa = new List<Values>();
            //vaa.Add(new Values() { id = 1, name = "Courage", score = t });
            //vaa.Add(new Values() { id = 2, name = "Commitment", score = t1 });
            //vaa.Add(new Values() { id = 3, name = "Focus", score = t2 });
            //vaa.Add(new Values() { id = 4, name = "Openness", score = t3 });
            //vaa.Add(new Values() { id = 5, name = "Respect", score = t4 });

            //ValuesList1 vaList1 = new ValuesList1();
            //vaList1.values = vaa;
            //return View(vaList1);

            return View();
        }
        public IActionResult ScrumValues()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}