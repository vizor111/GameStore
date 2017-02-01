using GameStore.Models;
using GameStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameStore
{
    public partial class Listing : System.Web.UI.Page
    {
        private int pageSize = 4;

        Repository repository = new Repository();

        protected int CurrentPage
        {
            get {int page;
                page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                return page > MaxPage ? MaxPage : page;
                    }
        }
        // Новое свойство, возвращающее наибольший номер допустимой страницы
        protected int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)repository.Games.Count()/pageSize);
            }
        }

        protected IEnumerable<Game> GetGames()
        {
            return repository.Games.OrderBy(g => g.GameId).Skip((CurrentPage - 1)* pageSize)
                .Take(pageSize);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}