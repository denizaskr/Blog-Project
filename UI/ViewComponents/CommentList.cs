using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogProject.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					UserName="Deniz"
				},
				new UserComment {
					ID=1,
					UserName="Yakup"
				},
				new UserComment
				{
					ID=1,
					UserName="Doga"
				}
			};
			return View(commentValues);
		}
	}
}
