using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using worldcupLib.Interface;

namespace worldcupLib.Repo
{
	public class RepoFactory
	{
  public static IFile GetFileRepository() => new FileRepo();

  public static IRepo GetChampionship(string gender_selection)
  {
   if (gender_selection == "Men")
   {
    return new MenRepo();
   }
   else
   {
    return new WomenRepo();
   }
  }
 }
}
