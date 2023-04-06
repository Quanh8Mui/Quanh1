using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanh3
{
    internal class Phanso
    {
        int tuso;
        int mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }

        public Phanso(int ts, int ms)
        {
            tuso = ts;
            mauso = ms == 0 ? 1 : ms;
        }

        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }

        public int Mauso
        {
            get { return mauso; }
            set { mauso = value; }
        }

        public Phanso Cong(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso + mauso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }

        public Phanso Tru(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso - mauso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }

        public Phanso Nhan(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }

        public Phanso Chia(Phanso p)
        {
            Phanso kq = new Phanso();
            if(p.tuso == 0)
            {
                p.tuso = 1;
                kq.tuso = tuso * p.mauso;
                kq.mauso = mauso * p.tuso;
            }
            else
            {
                kq.tuso = tuso * p.mauso;
                kq.mauso = mauso * p.tuso;
            }
            kq.Toigian();
            return kq;
        }

        public void Toigian()
        {
            int ucln = Lopdungchung.UCLN(tuso, mauso);
            if (ucln > 0)
            {
                tuso = tuso / ucln;
                mauso = mauso / ucln;
            }
        }
    }
}

