using MareaUnire.Model;
using MareaUnire.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareaUnire.Service
{
    public class QuizService
    {
        IRepository<Intrebare> intrebariRepository;

        public QuizService(IRepository<Intrebare> intrebariRepository)
        {
            this.intrebariRepository = intrebariRepository;
            this.intrebariRepository.LoadIntrebari();
        }

        public List<Intrebare> GetRandomIntrebari()
        {
            return intrebariRepository.GetAll().Take(10).ToList();
        }
    }
}
