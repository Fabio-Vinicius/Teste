using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class NomBlankStringList: Collection<string>
    {
        protected override void InsertItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException("Elementos não podem ser nulos nem em branco");
            }
            else
            {
                base.InsertItem(index, item);
            }
        }

        protected override void SetItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException("Elementos não podem ser nulos nem em branco");
            }
            else
            {
                base.InsertItem(index, item);
            }
        }


    }
}
