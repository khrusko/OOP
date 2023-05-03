using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using worldcupLib.Models;

namespace worldcupLib.Interface
{
	public interface IFile
	{
  //Team Save&Load
  void SaveFavoriteTeam(Team team);
  string LoadFavoriteTeam();
  //Resolution Save&Load
  void SaveResolution(string res);
  string LoadResolution();

  //Settings Save&Load
  void SaveSettings(string lang, string champ);
  List<string> LoadSettings();
  //FavoritePlayers Save&Load
  void SaveFavoritePlayers(IList<Player> players);
  List<Player> LoadFavoritePlayers();

  //PlayerImages Save&Load
  void SavePlayerImages(Player player);
  List<Player> LoadPlayerImages();



 }
}
