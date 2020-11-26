using System;

namespace _240620
{
    enum GunMode
    {
        Single,
        Multi
    }

    class Gun
    {
        public int PistolCapacity { get; private set; }
        public int CurrentPistol { get; private set; }
        public GunMode Mode { get; private set; }
        public int TotalPistol { get; private set; }

        public Gun(int pistolCapacy)
        {
            this.PistolCapacity = pistolCapacy;
        }

        public Gun(int pistolCapacity,GunMode mode)
        {
            this.PistolCapacity = pistolCapacity;
            this.Mode = mode;
        }

        public bool Shoot()
        {
            if (this.CurrentPistol == 0) return false;

            if (this.Mode == GunMode.Single)
            {
                if (this.CurrentPistol < 1) return false;

                this.CurrentPistol--;
            }
            else
            {
                int min = 2;
                int max = Convert.ToInt32(this.PistolCapacity * 0.2);

                Random random = new Random();
                int gunCount = random.Next(min, max);

                if (this.CurrentPistol < gunCount)
                {
                    this.CurrentPistol = 0;
                }
                else
                {
                    this.CurrentPistol -= gunCount;
                }
            }

            return true;
        }

        public bool Reload()
        {
            if (this.TotalPistol == 0) return false;

            int diff = this.PistolCapacity - this.CurrentPistol;

            if (diff >= this.TotalPistol)
            {
                this.CurrentPistol += this.TotalPistol;
                this.TotalPistol = 0;
            }
            else
            {
                this.CurrentPistol += diff;
                this.TotalPistol -= diff;
            }

            return true;
        }

        public void ChangeMode()
        {
            this.Mode = this.Mode == GunMode.Single ? GunMode.Multi : GunMode.Single;

            //if (this.Mode == GunMode.Single)
            //{
            //    this.Mode = GunMode.Multi;
            //}
            //else
            //{
            //    this.Mode = GunMode.Single;
            //}
        }

        public void AddPistol(int pistolCount)
        {
            this.TotalPistol += pistolCount;
        }

        public override string ToString()
        {
            return $"Current Pistol : {this.CurrentPistol}, Total Pistol : {this.TotalPistol}";
        }
    }
}
