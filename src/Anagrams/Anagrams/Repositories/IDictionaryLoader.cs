using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Repositories
{
    public interface IDictionaryLoader
    {
        List<string> LoadDictionary();
    }
}
