using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_ISP
{
    public interface IAve
    {
        void Volar();
        void Cantar();
        void PonerHuevos();
    }

    public interface IAveNadadora
    {
        void Nadar();
    }

    public interface IAveCazadora
    {
        void Cazar();
    }


}
