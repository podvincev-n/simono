using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork_Simonova_AV.Classes
{
    class Spend
    {
        private int id_spend;
        public int IdSpend
        {
            get
            {
                return id_spend;
            }

            set
            {
                id_spend = value;
            }
        }

        private int id_category;
        public int IdCategory
        {
            get
            {
                return id_category;
            }

            set
            {
                id_category = value;
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
