using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareaUnire.Repository {
    public interface IRepository<T> {
        void LoadIntrebari();
        List<T> GetAll();
    }
}
