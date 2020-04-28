using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork_Simonova_AV.Classes
{
    class Wallet
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private int sum;
        public int Sum
        {
            get
            {
                return sum;
            }

            set
            {
                sum = value;
            }
        }

        private int id_wallet;
        public int IdWallet
        {
            get
            {
                return id_wallet;
            }

            set
            {
                id_wallet = value;
            }
        }

        private int id_user;
        public int IdUser
        {
            get
            {
                return id_user;
            }

            set
            {
                id_user = value;
            }
        }


    }
}
