﻿using System;
using System.Collections.Generic;
using System.Text;
using wojilu.Web.Mvc;
using System.IO;
using wojilu.Web.Context;
using wojilu.Apps.Content.Domain;

namespace wojilu.Web.Controller.Content.Caching.Actions {

    public class PostDeleteCache : ActionCache {


        public override string GetCacheKey( Context.MvcContext ctx, string actionName ) {
            return null;
        }

        public override void ObserveActions() {

            Admin.Common.PostController post = new wojilu.Web.Controller.Content.Admin.Common.PostController();
            observe( post.Delete );
            observe( post.DeleteTrue );

            //---------------------------------------------------------

            Admin.Section.ListController list = new wojilu.Web.Controller.Content.Admin.Section.ListController();
            observe( list.Delete );

            Admin.Section.TalkController talk = new wojilu.Web.Controller.Content.Admin.Section.TalkController();
            observe( talk.Delete );

            Admin.Section.TextController txt = new wojilu.Web.Controller.Content.Admin.Section.TextController();
            observe( txt.Delete );

            Admin.Section.VideoController video = new wojilu.Web.Controller.Content.Admin.Section.VideoController();
            observe( video.Delete );

            Admin.Section.ImgController img = new wojilu.Web.Controller.Content.Admin.Section.ImgController();
            observe( img.Delete );

            Admin.Common.PollController poll = new wojilu.Web.Controller.Content.Admin.Common.PollController();
            observe( poll.Delete );
        }

        public override void UpdateCache( Context.MvcContext ctx ) {

            HtmlHelper.DeleteDetailHtml( ctx );
            new HtmlListMaker().MakeHtml( ctx );
            // 频道首页生成在 ContentIndexCache 中监控

        }




    }

}