#region GeneratedCode
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Eighty.Twenty
{
    public abstract partial class HtmlBuilder
    {
        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string xmlns = null
        )
        {
            StartTagRaw("html");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (xmlns != null)
            {
                Attr(new Eighty.Attr("xmlns", xmlns));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder html(params Attr[] attrs)
        {
            StartTagRaw("html");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder html(IEnumerable<Attr> attrs)
        {
            StartTagRaw("html");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }
        
        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1)
        {
            StartTagRaw("html");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1, Attr attr2)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("head");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder head(params Attr[] attrs)
        {
            StartTagRaw("head");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder head(IEnumerable<Attr> attrs)
        {
            StartTagRaw("head");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }
        
        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1)
        {
            StartTagRaw("head");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1, Attr attr2)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("body");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder body(params Attr[] attrs)
        {
            StartTagRaw("body");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder body(IEnumerable<Attr> attrs)
        {
            StartTagRaw("body");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }
        
        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1)
        {
            StartTagRaw("body");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1, Attr attr2)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string crossorigin = null,
            string rel = null,
            string href = null,
            string type = null,
            string media = null,
            string sizes = null
        )
        {
            StartTagRaw("link");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (crossorigin != null)
            {
                Attr(new Eighty.Attr("crossorigin", crossorigin));
            }
            if (rel != null)
            {
                Attr(new Eighty.Attr("rel", rel));
            }
            if (href != null)
            {
                Attr(new Eighty.Attr("href", href));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (media != null)
            {
                Attr(new Eighty.Attr("media", media));
            }
            if (sizes != null)
            {
                Attr(new Eighty.Attr("sizes", sizes));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a link element.
        /// </summary>
        protected void link(params Attr[] attrs)
        {
            StartTagRaw("link");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a link element.
        /// </summary>
        protected void link(IEnumerable<Attr> attrs)
        {
            StartTagRaw("link");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1)
        {
            StartTagRaw("link");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string href = null,
            string target = null
        )
        {
            StartTagRaw("base");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (href != null)
            {
                Attr(new Eighty.Attr("href", href));
            }
            if (target != null)
            {
                Attr(new Eighty.Attr("target", target));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a base element.
        /// </summary>
        protected void @base(params Attr[] attrs)
        {
            StartTagRaw("base");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a base element.
        /// </summary>
        protected void @base(IEnumerable<Attr> attrs)
        {
            StartTagRaw("base");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1)
        {
            StartTagRaw("base");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string charset = null,
            string target = null
        )
        {
            StartTagRaw("meta");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (charset != null)
            {
                Attr(new Eighty.Attr("charset", charset));
            }
            if (target != null)
            {
                Attr(new Eighty.Attr("target", target));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a meta element.
        /// </summary>
        protected void meta(params Attr[] attrs)
        {
            StartTagRaw("meta");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a meta element.
        /// </summary>
        protected void meta(IEnumerable<Attr> attrs)
        {
            StartTagRaw("meta");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1)
        {
            StartTagRaw("meta");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            string media = null
        )
        {
            StartTagRaw("style");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (media != null)
            {
                Attr(new Eighty.Attr("media", media));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder style(params Attr[] attrs)
        {
            StartTagRaw("style");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder style(IEnumerable<Attr> attrs)
        {
            StartTagRaw("style");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }
        
        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1)
        {
            StartTagRaw("style");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1, Attr attr2)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("title");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder title(params Attr[] attrs)
        {
            StartTagRaw("title");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder title(IEnumerable<Attr> attrs)
        {
            StartTagRaw("title");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }
        
        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1)
        {
            StartTagRaw("title");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1, Attr attr2)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            string src = null,
            string crossorigin = null,
            bool async = false
        )
        {
            StartTagRaw("script");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (crossorigin != null)
            {
                Attr(new Eighty.Attr("crossorigin", crossorigin));
            }
            if (async)
            {
                Attr(Eighty.Attr.Raw("async"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder script(params Attr[] attrs)
        {
            StartTagRaw("script");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder script(IEnumerable<Attr> attrs)
        {
            StartTagRaw("script");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }
        
        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1)
        {
            StartTagRaw("script");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1, Attr attr2)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("noscript");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder noscript(params Attr[] attrs)
        {
            StartTagRaw("noscript");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder noscript(IEnumerable<Attr> attrs)
        {
            StartTagRaw("noscript");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }
        
        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1)
        {
            StartTagRaw("noscript");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1, Attr attr2)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("main");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder main(params Attr[] attrs)
        {
            StartTagRaw("main");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder main(IEnumerable<Attr> attrs)
        {
            StartTagRaw("main");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }
        
        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1)
        {
            StartTagRaw("main");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1, Attr attr2)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("header");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder header(params Attr[] attrs)
        {
            StartTagRaw("header");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder header(IEnumerable<Attr> attrs)
        {
            StartTagRaw("header");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }
        
        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1)
        {
            StartTagRaw("header");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1, Attr attr2)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("article");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder article(params Attr[] attrs)
        {
            StartTagRaw("article");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder article(IEnumerable<Attr> attrs)
        {
            StartTagRaw("article");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }
        
        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1)
        {
            StartTagRaw("article");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1, Attr attr2)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("section");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder section(params Attr[] attrs)
        {
            StartTagRaw("section");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder section(IEnumerable<Attr> attrs)
        {
            StartTagRaw("section");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }
        
        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1)
        {
            StartTagRaw("section");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1, Attr attr2)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("footer");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder footer(params Attr[] attrs)
        {
            StartTagRaw("footer");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder footer(IEnumerable<Attr> attrs)
        {
            StartTagRaw("footer");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }
        
        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1)
        {
            StartTagRaw("footer");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1, Attr attr2)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("h1");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h1(params Attr[] attrs)
        {
            StartTagRaw("h1");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h1(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h1");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }
        
        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1)
        {
            StartTagRaw("h1");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1, Attr attr2)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("h2");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h2(params Attr[] attrs)
        {
            StartTagRaw("h2");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h2(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h2");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }
        
        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1)
        {
            StartTagRaw("h2");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1, Attr attr2)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("h3");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h3(params Attr[] attrs)
        {
            StartTagRaw("h3");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h3(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h3");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }
        
        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1)
        {
            StartTagRaw("h3");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1, Attr attr2)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("h4");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h4(params Attr[] attrs)
        {
            StartTagRaw("h4");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h4(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h4");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }
        
        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1)
        {
            StartTagRaw("h4");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1, Attr attr2)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("h5");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h5(params Attr[] attrs)
        {
            StartTagRaw("h5");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h5(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h5");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }
        
        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1)
        {
            StartTagRaw("h5");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1, Attr attr2)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("h6");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h6(params Attr[] attrs)
        {
            StartTagRaw("h6");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder h6(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h6");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }
        
        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1)
        {
            StartTagRaw("h6");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1, Attr attr2)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("hgroup");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder hgroup(params Attr[] attrs)
        {
            StartTagRaw("hgroup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder hgroup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("hgroup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }
        
        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1)
        {
            StartTagRaw("hgroup");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1, Attr attr2)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("div");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder div(params Attr[] attrs)
        {
            StartTagRaw("div");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder div(IEnumerable<Attr> attrs)
        {
            StartTagRaw("div");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }
        
        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1)
        {
            StartTagRaw("div");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1, Attr attr2)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("p");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder p(params Attr[] attrs)
        {
            StartTagRaw("p");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder p(IEnumerable<Attr> attrs)
        {
            StartTagRaw("p");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }
        
        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1)
        {
            StartTagRaw("p");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1, Attr attr2)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("pre");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder pre(params Attr[] attrs)
        {
            StartTagRaw("pre");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder pre(IEnumerable<Attr> attrs)
        {
            StartTagRaw("pre");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }
        
        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1)
        {
            StartTagRaw("pre");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1, Attr attr2)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("blockquote");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder blockquote(params Attr[] attrs)
        {
            StartTagRaw("blockquote");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder blockquote(IEnumerable<Attr> attrs)
        {
            StartTagRaw("blockquote");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }
        
        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1)
        {
            StartTagRaw("blockquote");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1, Attr attr2)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("figure");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder figure(params Attr[] attrs)
        {
            StartTagRaw("figure");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder figure(IEnumerable<Attr> attrs)
        {
            StartTagRaw("figure");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }
        
        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1)
        {
            StartTagRaw("figure");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1, Attr attr2)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("figcaption");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder figcaption(params Attr[] attrs)
        {
            StartTagRaw("figcaption");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder figcaption(IEnumerable<Attr> attrs)
        {
            StartTagRaw("figcaption");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }
        
        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1)
        {
            StartTagRaw("figcaption");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1, Attr attr2)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("aside");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder aside(params Attr[] attrs)
        {
            StartTagRaw("aside");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder aside(IEnumerable<Attr> attrs)
        {
            StartTagRaw("aside");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }
        
        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1)
        {
            StartTagRaw("aside");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1, Attr attr2)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("nav");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder nav(params Attr[] attrs)
        {
            StartTagRaw("nav");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder nav(IEnumerable<Attr> attrs)
        {
            StartTagRaw("nav");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }
        
        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1)
        {
            StartTagRaw("nav");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1, Attr attr2)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("address");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder address(params Attr[] attrs)
        {
            StartTagRaw("address");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder address(IEnumerable<Attr> attrs)
        {
            StartTagRaw("address");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }
        
        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1)
        {
            StartTagRaw("address");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1, Attr attr2)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string href = null,
            string rel = null,
            string target = null,
            string type = null,
            string download = null
        )
        {
            StartTagRaw("a");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (href != null)
            {
                Attr(new Eighty.Attr("href", href));
            }
            if (rel != null)
            {
                Attr(new Eighty.Attr("rel", rel));
            }
            if (target != null)
            {
                Attr(new Eighty.Attr("target", target));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (download != null)
            {
                Attr(new Eighty.Attr("download", download));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder a(params Attr[] attrs)
        {
            StartTagRaw("a");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder a(IEnumerable<Attr> attrs)
        {
            StartTagRaw("a");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }
        
        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1)
        {
            StartTagRaw("a");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1, Attr attr2)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("b");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder b(params Attr[] attrs)
        {
            StartTagRaw("b");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder b(IEnumerable<Attr> attrs)
        {
            StartTagRaw("b");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }
        
        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1)
        {
            StartTagRaw("b");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1, Attr attr2)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("em");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder em(params Attr[] attrs)
        {
            StartTagRaw("em");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder em(IEnumerable<Attr> attrs)
        {
            StartTagRaw("em");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }
        
        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1)
        {
            StartTagRaw("em");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1, Attr attr2)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("i");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder i(params Attr[] attrs)
        {
            StartTagRaw("i");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder i(IEnumerable<Attr> attrs)
        {
            StartTagRaw("i");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }
        
        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1)
        {
            StartTagRaw("i");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1, Attr attr2)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("mark");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder mark(params Attr[] attrs)
        {
            StartTagRaw("mark");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder mark(IEnumerable<Attr> attrs)
        {
            StartTagRaw("mark");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }
        
        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1)
        {
            StartTagRaw("mark");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1, Attr attr2)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string cite = null
        )
        {
            StartTagRaw("q");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (cite != null)
            {
                Attr(new Eighty.Attr("cite", cite));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder q(params Attr[] attrs)
        {
            StartTagRaw("q");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder q(IEnumerable<Attr> attrs)
        {
            StartTagRaw("q");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }
        
        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1)
        {
            StartTagRaw("q");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1, Attr attr2)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("s");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder s(params Attr[] attrs)
        {
            StartTagRaw("s");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder s(IEnumerable<Attr> attrs)
        {
            StartTagRaw("s");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }
        
        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1)
        {
            StartTagRaw("s");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1, Attr attr2)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("small");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder small(params Attr[] attrs)
        {
            StartTagRaw("small");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder small(IEnumerable<Attr> attrs)
        {
            StartTagRaw("small");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }
        
        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1)
        {
            StartTagRaw("small");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1, Attr attr2)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("span");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder span(params Attr[] attrs)
        {
            StartTagRaw("span");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder span(IEnumerable<Attr> attrs)
        {
            StartTagRaw("span");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }
        
        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1)
        {
            StartTagRaw("span");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1, Attr attr2)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("strong");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder strong(params Attr[] attrs)
        {
            StartTagRaw("strong");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder strong(IEnumerable<Attr> attrs)
        {
            StartTagRaw("strong");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }
        
        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1)
        {
            StartTagRaw("strong");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1, Attr attr2)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("sub");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder sub(params Attr[] attrs)
        {
            StartTagRaw("sub");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder sub(IEnumerable<Attr> attrs)
        {
            StartTagRaw("sub");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }
        
        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1)
        {
            StartTagRaw("sub");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1, Attr attr2)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("sup");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder sup(params Attr[] attrs)
        {
            StartTagRaw("sup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder sup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("sup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }
        
        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1)
        {
            StartTagRaw("sup");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1, Attr attr2)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("u");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder u(params Attr[] attrs)
        {
            StartTagRaw("u");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder u(IEnumerable<Attr> attrs)
        {
            StartTagRaw("u");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }
        
        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1)
        {
            StartTagRaw("u");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1, Attr attr2)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("br");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a br element.
        /// </summary>
        protected void br(params Attr[] attrs)
        {
            StartTagRaw("br");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a br element.
        /// </summary>
        protected void br(IEnumerable<Attr> attrs)
        {
            StartTagRaw("br");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1)
        {
            StartTagRaw("br");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("wbr");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a wbr element.
        /// </summary>
        protected void wbr(params Attr[] attrs)
        {
            StartTagRaw("wbr");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a wbr element.
        /// </summary>
        protected void wbr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("wbr");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1)
        {
            StartTagRaw("wbr");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("hr");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an hr element.
        /// </summary>
        protected void hr(params Attr[] attrs)
        {
            StartTagRaw("hr");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an hr element.
        /// </summary>
        protected void hr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("hr");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1)
        {
            StartTagRaw("hr");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("abbr");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder abbr(params Attr[] attrs)
        {
            StartTagRaw("abbr");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder abbr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("abbr");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }
        
        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1)
        {
            StartTagRaw("abbr");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1, Attr attr2)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("cite");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder cite(params Attr[] attrs)
        {
            StartTagRaw("cite");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder cite(IEnumerable<Attr> attrs)
        {
            StartTagRaw("cite");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }
        
        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1)
        {
            StartTagRaw("cite");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1, Attr attr2)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("code");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder code(params Attr[] attrs)
        {
            StartTagRaw("code");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder code(IEnumerable<Attr> attrs)
        {
            StartTagRaw("code");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }
        
        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1)
        {
            StartTagRaw("code");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1, Attr attr2)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string value = null
        )
        {
            StartTagRaw("data");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder data(params Attr[] attrs)
        {
            StartTagRaw("data");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder data(IEnumerable<Attr> attrs)
        {
            StartTagRaw("data");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }
        
        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1)
        {
            StartTagRaw("data");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1, Attr attr2)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("dfn");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dfn(params Attr[] attrs)
        {
            StartTagRaw("dfn");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dfn(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dfn");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }
        
        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1)
        {
            StartTagRaw("dfn");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1, Attr attr2)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("kbd");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder kbd(params Attr[] attrs)
        {
            StartTagRaw("kbd");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder kbd(IEnumerable<Attr> attrs)
        {
            StartTagRaw("kbd");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }
        
        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1)
        {
            StartTagRaw("kbd");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1, Attr attr2)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("samp");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder samp(params Attr[] attrs)
        {
            StartTagRaw("samp");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder samp(IEnumerable<Attr> attrs)
        {
            StartTagRaw("samp");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }
        
        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1)
        {
            StartTagRaw("samp");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1, Attr attr2)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string datetime = null
        )
        {
            StartTagRaw("time");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (datetime != null)
            {
                Attr(new Eighty.Attr("datetime", datetime));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder time(params Attr[] attrs)
        {
            StartTagRaw("time");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder time(IEnumerable<Attr> attrs)
        {
            StartTagRaw("time");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }
        
        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1)
        {
            StartTagRaw("time");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1, Attr attr2)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            bool reversed = false,
            string start = null
        )
        {
            StartTagRaw("ol");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (reversed)
            {
                Attr(Eighty.Attr.Raw("reversed"));
            }
            if (start != null)
            {
                Attr(new Eighty.Attr("start", start));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder ol(params Attr[] attrs)
        {
            StartTagRaw("ol");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder ol(IEnumerable<Attr> attrs)
        {
            StartTagRaw("ol");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }
        
        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1)
        {
            StartTagRaw("ol");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1, Attr attr2)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            bool reversed = false,
            string start = null
        )
        {
            StartTagRaw("ul");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (reversed)
            {
                Attr(Eighty.Attr.Raw("reversed"));
            }
            if (start != null)
            {
                Attr(new Eighty.Attr("start", start));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder ul(params Attr[] attrs)
        {
            StartTagRaw("ul");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder ul(IEnumerable<Attr> attrs)
        {
            StartTagRaw("ul");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }
        
        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1)
        {
            StartTagRaw("ul");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1, Attr attr2)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string value = null
        )
        {
            StartTagRaw("li");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder li(params Attr[] attrs)
        {
            StartTagRaw("li");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder li(IEnumerable<Attr> attrs)
        {
            StartTagRaw("li");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }
        
        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1)
        {
            StartTagRaw("li");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1, Attr attr2)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("dl");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dl(params Attr[] attrs)
        {
            StartTagRaw("dl");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dl(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dl");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }
        
        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1)
        {
            StartTagRaw("dl");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1, Attr attr2)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("dt");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dt(params Attr[] attrs)
        {
            StartTagRaw("dt");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dt(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dt");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }
        
        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1)
        {
            StartTagRaw("dt");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1, Attr attr2)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("dd");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dd(params Attr[] attrs)
        {
            StartTagRaw("dd");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dd(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dd");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }
        
        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1)
        {
            StartTagRaw("dd");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1, Attr attr2)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("table");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder table(params Attr[] attrs)
        {
            StartTagRaw("table");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder table(IEnumerable<Attr> attrs)
        {
            StartTagRaw("table");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }
        
        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1)
        {
            StartTagRaw("table");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1, Attr attr2)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("caption");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder caption(params Attr[] attrs)
        {
            StartTagRaw("caption");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder caption(IEnumerable<Attr> attrs)
        {
            StartTagRaw("caption");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }
        
        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1)
        {
            StartTagRaw("caption");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1, Attr attr2)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("thead");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder thead(params Attr[] attrs)
        {
            StartTagRaw("thead");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder thead(IEnumerable<Attr> attrs)
        {
            StartTagRaw("thead");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }
        
        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1)
        {
            StartTagRaw("thead");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1, Attr attr2)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string span = null
        )
        {
            StartTagRaw("colgroup");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (span != null)
            {
                Attr(new Eighty.Attr("span", span));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder colgroup(params Attr[] attrs)
        {
            StartTagRaw("colgroup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder colgroup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("colgroup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }
        
        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1)
        {
            StartTagRaw("colgroup");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1, Attr attr2)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string span = null
        )
        {
            StartTagRaw("col");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (span != null)
            {
                Attr(new Eighty.Attr("span", span));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder col(params Attr[] attrs)
        {
            StartTagRaw("col");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder col(IEnumerable<Attr> attrs)
        {
            StartTagRaw("col");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }
        
        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1)
        {
            StartTagRaw("col");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1, Attr attr2)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("tbody");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder tbody(params Attr[] attrs)
        {
            StartTagRaw("tbody");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder tbody(IEnumerable<Attr> attrs)
        {
            StartTagRaw("tbody");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }
        
        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1)
        {
            StartTagRaw("tbody");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1, Attr attr2)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("tr");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder tr(params Attr[] attrs)
        {
            StartTagRaw("tr");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder tr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("tr");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }
        
        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1)
        {
            StartTagRaw("tr");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1, Attr attr2)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string colspan = null,
            string rowspan = null,
            string headers = null,
            string scope = null
        )
        {
            StartTagRaw("th");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (colspan != null)
            {
                Attr(new Eighty.Attr("colspan", colspan));
            }
            if (rowspan != null)
            {
                Attr(new Eighty.Attr("rowspan", rowspan));
            }
            if (headers != null)
            {
                Attr(new Eighty.Attr("headers", headers));
            }
            if (scope != null)
            {
                Attr(new Eighty.Attr("scope", scope));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder th(params Attr[] attrs)
        {
            StartTagRaw("th");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder th(IEnumerable<Attr> attrs)
        {
            StartTagRaw("th");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }
        
        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1)
        {
            StartTagRaw("th");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1, Attr attr2)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string colspan = null,
            string rowspan = null,
            string headers = null
        )
        {
            StartTagRaw("td");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (colspan != null)
            {
                Attr(new Eighty.Attr("colspan", colspan));
            }
            if (rowspan != null)
            {
                Attr(new Eighty.Attr("rowspan", rowspan));
            }
            if (headers != null)
            {
                Attr(new Eighty.Attr("headers", headers));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder td(params Attr[] attrs)
        {
            StartTagRaw("td");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder td(IEnumerable<Attr> attrs)
        {
            StartTagRaw("td");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }
        
        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1)
        {
            StartTagRaw("td");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1, Attr attr2)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("tfoot");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder tfoot(params Attr[] attrs)
        {
            StartTagRaw("tfoot");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder tfoot(IEnumerable<Attr> attrs)
        {
            StartTagRaw("tfoot");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }
        
        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1)
        {
            StartTagRaw("tfoot");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1, Attr attr2)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string name = null,
            string action = null,
            string method = null,
            string autocomplete = null,
            string target = null,
            string enctype = null,
            bool novalidate = false
        )
        {
            StartTagRaw("form");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (action != null)
            {
                Attr(new Eighty.Attr("action", action));
            }
            if (method != null)
            {
                Attr(new Eighty.Attr("method", method));
            }
            if (autocomplete != null)
            {
                Attr(new Eighty.Attr("autocomplete", autocomplete));
            }
            if (target != null)
            {
                Attr(new Eighty.Attr("target", target));
            }
            if (enctype != null)
            {
                Attr(new Eighty.Attr("enctype", enctype));
            }
            if (novalidate)
            {
                Attr(Eighty.Attr.Raw("novalidate"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder form(params Attr[] attrs)
        {
            StartTagRaw("form");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder form(IEnumerable<Attr> attrs)
        {
            StartTagRaw("form");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }
        
        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1)
        {
            StartTagRaw("form");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1, Attr attr2)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string name = null,
            bool disabled = false,
            string form = null
        )
        {
            StartTagRaw("fieldset");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder fieldset(params Attr[] attrs)
        {
            StartTagRaw("fieldset");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder fieldset(IEnumerable<Attr> attrs)
        {
            StartTagRaw("fieldset");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }
        
        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1)
        {
            StartTagRaw("fieldset");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1, Attr attr2)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string @for = null
        )
        {
            StartTagRaw("label");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (@for != null)
            {
                Attr(new Eighty.Attr("for", @for));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder label(params Attr[] attrs)
        {
            StartTagRaw("label");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder label(IEnumerable<Attr> attrs)
        {
            StartTagRaw("label");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }
        
        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1)
        {
            StartTagRaw("label");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1, Attr attr2)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string name = null,
            string type = null,
            string multiple = null,
            string value = null,
            string placeholder = null,
            string size = null,
            string autocomplete = null,
            string list = null,
            bool autofocus = false,
            bool @checked = false,
            bool disabled = false,
            bool @readonly = false,
            bool required = false,
            string src = null,
            string height = null,
            string width = null,
            string max = null,
            string min = null,
            string step = null,
            string maxlength = null,
            string minlength = null,
            string pattern = null,
            string form = null,
            string formaction = null,
            string formmethod = null,
            string formtarget = null,
            string formenctype = null,
            bool formnovalidate = false
        )
        {
            StartTagRaw("input");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (multiple != null)
            {
                Attr(new Eighty.Attr("multiple", multiple));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            if (placeholder != null)
            {
                Attr(new Eighty.Attr("placeholder", placeholder));
            }
            if (size != null)
            {
                Attr(new Eighty.Attr("size", size));
            }
            if (autocomplete != null)
            {
                Attr(new Eighty.Attr("autocomplete", autocomplete));
            }
            if (list != null)
            {
                Attr(new Eighty.Attr("list", list));
            }
            if (autofocus)
            {
                Attr(Eighty.Attr.Raw("autofocus"));
            }
            if (@checked)
            {
                Attr(Eighty.Attr.Raw("checked"));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            if (@readonly)
            {
                Attr(Eighty.Attr.Raw("readonly"));
            }
            if (required)
            {
                Attr(Eighty.Attr.Raw("required"));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (height != null)
            {
                Attr(new Eighty.Attr("height", height));
            }
            if (width != null)
            {
                Attr(new Eighty.Attr("width", width));
            }
            if (max != null)
            {
                Attr(new Eighty.Attr("max", max));
            }
            if (min != null)
            {
                Attr(new Eighty.Attr("min", min));
            }
            if (step != null)
            {
                Attr(new Eighty.Attr("step", step));
            }
            if (maxlength != null)
            {
                Attr(new Eighty.Attr("maxlength", maxlength));
            }
            if (minlength != null)
            {
                Attr(new Eighty.Attr("minlength", minlength));
            }
            if (pattern != null)
            {
                Attr(new Eighty.Attr("pattern", pattern));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            if (formaction != null)
            {
                Attr(new Eighty.Attr("formaction", formaction));
            }
            if (formmethod != null)
            {
                Attr(new Eighty.Attr("formmethod", formmethod));
            }
            if (formtarget != null)
            {
                Attr(new Eighty.Attr("formtarget", formtarget));
            }
            if (formenctype != null)
            {
                Attr(new Eighty.Attr("formenctype", formenctype));
            }
            if (formnovalidate)
            {
                Attr(Eighty.Attr.Raw("formnovalidate"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder input(params Attr[] attrs)
        {
            StartTagRaw("input");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder input(IEnumerable<Attr> attrs)
        {
            StartTagRaw("input");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }
        
        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1)
        {
            StartTagRaw("input");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1, Attr attr2)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string name = null,
            string type = null,
            string value = null,
            bool autofocus = false,
            bool disabled = false,
            string src = null,
            string height = null,
            string width = null,
            string form = null,
            string formaction = null,
            string formmethod = null,
            string formtarget = null,
            string formenctype = null,
            bool formnovalidate = false
        )
        {
            StartTagRaw("button");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            if (autofocus)
            {
                Attr(Eighty.Attr.Raw("autofocus"));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (height != null)
            {
                Attr(new Eighty.Attr("height", height));
            }
            if (width != null)
            {
                Attr(new Eighty.Attr("width", width));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            if (formaction != null)
            {
                Attr(new Eighty.Attr("formaction", formaction));
            }
            if (formmethod != null)
            {
                Attr(new Eighty.Attr("formmethod", formmethod));
            }
            if (formtarget != null)
            {
                Attr(new Eighty.Attr("formtarget", formtarget));
            }
            if (formenctype != null)
            {
                Attr(new Eighty.Attr("formenctype", formenctype));
            }
            if (formnovalidate)
            {
                Attr(Eighty.Attr.Raw("formnovalidate"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder button(params Attr[] attrs)
        {
            StartTagRaw("button");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder button(IEnumerable<Attr> attrs)
        {
            StartTagRaw("button");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }
        
        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1)
        {
            StartTagRaw("button");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1, Attr attr2)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string name = null,
            string placeholder = null,
            string autocomplete = null,
            string cols = null,
            string rows = null,
            string wrap = null,
            bool autofocus = false,
            bool disabled = false,
            bool @readonly = false,
            bool required = false,
            string src = null,
            string maxlength = null,
            string minlength = null,
            string form = null
        )
        {
            StartTagRaw("textarea");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (placeholder != null)
            {
                Attr(new Eighty.Attr("placeholder", placeholder));
            }
            if (autocomplete != null)
            {
                Attr(new Eighty.Attr("autocomplete", autocomplete));
            }
            if (cols != null)
            {
                Attr(new Eighty.Attr("cols", cols));
            }
            if (rows != null)
            {
                Attr(new Eighty.Attr("rows", rows));
            }
            if (wrap != null)
            {
                Attr(new Eighty.Attr("wrap", wrap));
            }
            if (autofocus)
            {
                Attr(Eighty.Attr.Raw("autofocus"));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            if (@readonly)
            {
                Attr(Eighty.Attr.Raw("readonly"));
            }
            if (required)
            {
                Attr(Eighty.Attr.Raw("required"));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (maxlength != null)
            {
                Attr(new Eighty.Attr("maxlength", maxlength));
            }
            if (minlength != null)
            {
                Attr(new Eighty.Attr("minlength", minlength));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder textarea(params Attr[] attrs)
        {
            StartTagRaw("textarea");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder textarea(IEnumerable<Attr> attrs)
        {
            StartTagRaw("textarea");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }
        
        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1)
        {
            StartTagRaw("textarea");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1, Attr attr2)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("datalist");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder datalist(params Attr[] attrs)
        {
            StartTagRaw("datalist");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder datalist(IEnumerable<Attr> attrs)
        {
            StartTagRaw("datalist");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }
        
        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1)
        {
            StartTagRaw("datalist");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1, Attr attr2)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string label = null,
            bool disabled = false
        )
        {
            StartTagRaw("optgroup");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (label != null)
            {
                Attr(new Eighty.Attr("label", label));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder optgroup(params Attr[] attrs)
        {
            StartTagRaw("optgroup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder optgroup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("optgroup");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }
        
        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1)
        {
            StartTagRaw("optgroup");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1, Attr attr2)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string name = null,
            string multiple = null,
            string size = null,
            bool autofocus = false,
            bool disabled = false,
            bool required = false,
            string form = null
        )
        {
            StartTagRaw("select");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (multiple != null)
            {
                Attr(new Eighty.Attr("multiple", multiple));
            }
            if (size != null)
            {
                Attr(new Eighty.Attr("size", size));
            }
            if (autofocus)
            {
                Attr(Eighty.Attr.Raw("autofocus"));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            if (required)
            {
                Attr(Eighty.Attr.Raw("required"));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder select(params Attr[] attrs)
        {
            StartTagRaw("select");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder select(IEnumerable<Attr> attrs)
        {
            StartTagRaw("select");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }
        
        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1)
        {
            StartTagRaw("select");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1, Attr attr2)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string label = null,
            string value = null,
            bool disabled = false,
            bool selected = false
        )
        {
            StartTagRaw("option");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (label != null)
            {
                Attr(new Eighty.Attr("label", label));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            if (selected)
            {
                Attr(Eighty.Attr.Raw("selected"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder option(params Attr[] attrs)
        {
            StartTagRaw("option");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder option(IEnumerable<Attr> attrs)
        {
            StartTagRaw("option");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }
        
        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1)
        {
            StartTagRaw("option");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1, Attr attr2)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("legend");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder legend(params Attr[] attrs)
        {
            StartTagRaw("legend");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder legend(IEnumerable<Attr> attrs)
        {
            StartTagRaw("legend");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }
        
        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1)
        {
            StartTagRaw("legend");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1, Attr attr2)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string value = null,
            string form = null,
            string max = null,
            string min = null,
            string low = null,
            string high = null,
            string optimum = null
        )
        {
            StartTagRaw("meter");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            if (max != null)
            {
                Attr(new Eighty.Attr("max", max));
            }
            if (min != null)
            {
                Attr(new Eighty.Attr("min", min));
            }
            if (low != null)
            {
                Attr(new Eighty.Attr("low", low));
            }
            if (high != null)
            {
                Attr(new Eighty.Attr("high", high));
            }
            if (optimum != null)
            {
                Attr(new Eighty.Attr("optimum", optimum));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder meter(params Attr[] attrs)
        {
            StartTagRaw("meter");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder meter(IEnumerable<Attr> attrs)
        {
            StartTagRaw("meter");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }
        
        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1)
        {
            StartTagRaw("meter");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1, Attr attr2)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string @for = null,
            string name = null,
            string form = null
        )
        {
            StartTagRaw("output");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (@for != null)
            {
                Attr(new Eighty.Attr("for", @for));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder output(params Attr[] attrs)
        {
            StartTagRaw("output");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder output(IEnumerable<Attr> attrs)
        {
            StartTagRaw("output");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }
        
        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1)
        {
            StartTagRaw("output");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1, Attr attr2)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string value = null,
            string max = null
        )
        {
            StartTagRaw("progress");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            if (max != null)
            {
                Attr(new Eighty.Attr("max", max));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder progress(params Attr[] attrs)
        {
            StartTagRaw("progress");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder progress(IEnumerable<Attr> attrs)
        {
            StartTagRaw("progress");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }
        
        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1)
        {
            StartTagRaw("progress");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1, Attr attr2)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            string label = null
        )
        {
            StartTagRaw("menu");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (label != null)
            {
                Attr(new Eighty.Attr("label", label));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder menu(params Attr[] attrs)
        {
            StartTagRaw("menu");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder menu(IEnumerable<Attr> attrs)
        {
            StartTagRaw("menu");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }
        
        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1)
        {
            StartTagRaw("menu");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1, Attr attr2)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            string label = null,
            string command = null,
            string icon = null,
            string radiogroup = null,
            bool disabled = false,
            bool @default = false,
            bool @checked = false
        )
        {
            StartTagRaw("menuitem");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (label != null)
            {
                Attr(new Eighty.Attr("label", label));
            }
            if (command != null)
            {
                Attr(new Eighty.Attr("command", command));
            }
            if (icon != null)
            {
                Attr(new Eighty.Attr("icon", icon));
            }
            if (radiogroup != null)
            {
                Attr(new Eighty.Attr("radiogroup", radiogroup));
            }
            if (disabled)
            {
                Attr(Eighty.Attr.Raw("disabled"));
            }
            if (@default)
            {
                Attr(Eighty.Attr.Raw("default"));
            }
            if (@checked)
            {
                Attr(Eighty.Attr.Raw("checked"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder menuitem(params Attr[] attrs)
        {
            StartTagRaw("menuitem");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder menuitem(IEnumerable<Attr> attrs)
        {
            StartTagRaw("menuitem");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }
        
        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1)
        {
            StartTagRaw("menuitem");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1, Attr attr2)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            bool open = false
        )
        {
            StartTagRaw("dialog");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (open)
            {
                Attr(Eighty.Attr.Raw("open"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dialog(params Attr[] attrs)
        {
            StartTagRaw("dialog");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder dialog(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dialog");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }
        
        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1)
        {
            StartTagRaw("dialog");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1, Attr attr2)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            bool open = false
        )
        {
            StartTagRaw("details");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (open)
            {
                Attr(Eighty.Attr.Raw("open"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder details(params Attr[] attrs)
        {
            StartTagRaw("details");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder details(IEnumerable<Attr> attrs)
        {
            StartTagRaw("details");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }
        
        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1)
        {
            StartTagRaw("details");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1, Attr attr2)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("summary");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder summary(params Attr[] attrs)
        {
            StartTagRaw("summary");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder summary(IEnumerable<Attr> attrs)
        {
            StartTagRaw("summary");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }
        
        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1)
        {
            StartTagRaw("summary");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1, Attr attr2)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string src = null,
            string alt = null,
            string height = null,
            string width = null,
            string srcset = null,
            string sizes = null,
            string crossorigin = null
        )
        {
            StartTagRaw("img");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (alt != null)
            {
                Attr(new Eighty.Attr("alt", alt));
            }
            if (height != null)
            {
                Attr(new Eighty.Attr("height", height));
            }
            if (width != null)
            {
                Attr(new Eighty.Attr("width", width));
            }
            if (srcset != null)
            {
                Attr(new Eighty.Attr("srcset", srcset));
            }
            if (sizes != null)
            {
                Attr(new Eighty.Attr("sizes", sizes));
            }
            if (crossorigin != null)
            {
                Attr(new Eighty.Attr("crossorigin", crossorigin));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an img element.
        /// </summary>
        protected void img(params Attr[] attrs)
        {
            StartTagRaw("img");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an img element.
        /// </summary>
        protected void img(IEnumerable<Attr> attrs)
        {
            StartTagRaw("img");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1)
        {
            StartTagRaw("img");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string src = null,
            string preload = null,
            string volume = null,
            bool autoplay = false,
            bool loop = false,
            bool muted = false,
            bool controls = false
        )
        {
            StartTagRaw("audio");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (preload != null)
            {
                Attr(new Eighty.Attr("preload", preload));
            }
            if (volume != null)
            {
                Attr(new Eighty.Attr("volume", volume));
            }
            if (autoplay)
            {
                Attr(Eighty.Attr.Raw("autoplay"));
            }
            if (loop)
            {
                Attr(Eighty.Attr.Raw("loop"));
            }
            if (muted)
            {
                Attr(Eighty.Attr.Raw("muted"));
            }
            if (controls)
            {
                Attr(Eighty.Attr.Raw("controls"));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder audio(params Attr[] attrs)
        {
            StartTagRaw("audio");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder audio(IEnumerable<Attr> attrs)
        {
            StartTagRaw("audio");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }
        
        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1)
        {
            StartTagRaw("audio");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1, Attr attr2)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string src = null,
            string height = null,
            string width = null,
            string poster = null,
            string preload = null,
            bool autoplay = false,
            bool loop = false,
            bool muted = false,
            bool controls = false,
            string crossorigin = null
        )
        {
            StartTagRaw("video");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (height != null)
            {
                Attr(new Eighty.Attr("height", height));
            }
            if (width != null)
            {
                Attr(new Eighty.Attr("width", width));
            }
            if (poster != null)
            {
                Attr(new Eighty.Attr("poster", poster));
            }
            if (preload != null)
            {
                Attr(new Eighty.Attr("preload", preload));
            }
            if (autoplay)
            {
                Attr(Eighty.Attr.Raw("autoplay"));
            }
            if (loop)
            {
                Attr(Eighty.Attr.Raw("loop"));
            }
            if (muted)
            {
                Attr(Eighty.Attr.Raw("muted"));
            }
            if (controls)
            {
                Attr(Eighty.Attr.Raw("controls"));
            }
            if (crossorigin != null)
            {
                Attr(new Eighty.Attr("crossorigin", crossorigin));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder video(params Attr[] attrs)
        {
            StartTagRaw("video");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder video(IEnumerable<Attr> attrs)
        {
            StartTagRaw("video");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }
        
        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1)
        {
            StartTagRaw("video");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1, Attr attr2)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string src = null,
            string label = null,
            string kind = null,
            bool @default = false
        )
        {
            StartTagRaw("track");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (label != null)
            {
                Attr(new Eighty.Attr("label", label));
            }
            if (kind != null)
            {
                Attr(new Eighty.Attr("kind", kind));
            }
            if (@default)
            {
                Attr(Eighty.Attr.Raw("default"));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a track element.
        /// </summary>
        protected void track(params Attr[] attrs)
        {
            StartTagRaw("track");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a track element.
        /// </summary>
        protected void track(IEnumerable<Attr> attrs)
        {
            StartTagRaw("track");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1)
        {
            StartTagRaw("track");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            string src = null,
            string height = null,
            string width = null
        )
        {
            StartTagRaw("embed");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            if (height != null)
            {
                Attr(new Eighty.Attr("height", height));
            }
            if (width != null)
            {
                Attr(new Eighty.Attr("width", width));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an embed element.
        /// </summary>
        protected void embed(params Attr[] attrs)
        {
            StartTagRaw("embed");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an embed element.
        /// </summary>
        protected void embed(IEnumerable<Attr> attrs)
        {
            StartTagRaw("embed");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1)
        {
            StartTagRaw("embed");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            string data = null,
            string height = null,
            string width = null,
            string name = null
        )
        {
            StartTagRaw("object");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (data != null)
            {
                Attr(new Eighty.Attr("data", data));
            }
            if (height != null)
            {
                Attr(new Eighty.Attr("height", height));
            }
            if (width != null)
            {
                Attr(new Eighty.Attr("width", width));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder @object(params Attr[] attrs)
        {
            StartTagRaw("object");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder @object(IEnumerable<Attr> attrs)
        {
            StartTagRaw("object");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }
        
        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1)
        {
            StartTagRaw("object");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1, Attr attr2)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string name = null,
            string value = null
        )
        {
            StartTagRaw("param");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (name != null)
            {
                Attr(new Eighty.Attr("name", name));
            }
            if (value != null)
            {
                Attr(new Eighty.Attr("value", value));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a param element.
        /// </summary>
        protected void param(params Attr[] attrs)
        {
            StartTagRaw("param");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a param element.
        /// </summary>
        protected void param(IEnumerable<Attr> attrs)
        {
            StartTagRaw("param");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1)
        {
            StartTagRaw("param");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTagRaw("picture");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder picture(params Attr[] attrs)
        {
            StartTagRaw("picture");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder picture(IEnumerable<Attr> attrs)
        {
            StartTagRaw("picture");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }
        
        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1)
        {
            StartTagRaw("picture");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1, Attr attr2)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string type = null,
            string src = null
        )
        {
            StartTagRaw("source");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (type != null)
            {
                Attr(new Eighty.Attr("type", type));
            }
            if (src != null)
            {
                Attr(new Eighty.Attr("src", src));
            }
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a source element.
        /// </summary>
        protected void source(params Attr[] attrs)
        {
            StartTagRaw("source");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a source element.
        /// </summary>
        protected void source(IEnumerable<Attr> attrs)
        {
            StartTagRaw("source");
            Attrs(attrs);
            Writer.WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1)
        {
            StartTagRaw("source");
            Attrs(attr1);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw("/>");
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string height = null,
            string width = null
        )
        {
            StartTagRaw("canvas");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (height != null)
            {
                Attr(new Eighty.Attr("height", height));
            }
            if (width != null)
            {
                Attr(new Eighty.Attr("width", width));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder canvas(params Attr[] attrs)
        {
            StartTagRaw("canvas");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder canvas(IEnumerable<Attr> attrs)
        {
            StartTagRaw("canvas");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }
        
        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1)
        {
            StartTagRaw("canvas");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1, Attr attr2)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string dir = null
        )
        {
            StartTagRaw("bdi");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (dir != null)
            {
                Attr(new Eighty.Attr("dir", dir));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder bdi(params Attr[] attrs)
        {
            StartTagRaw("bdi");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder bdi(IEnumerable<Attr> attrs)
        {
            StartTagRaw("bdi");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }
        
        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1)
        {
            StartTagRaw("bdi");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1, Attr attr2)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string dir = null
        )
        {
            StartTagRaw("bdo");
            
            if (id != null)
            {
                Attr(new Eighty.Attr("id", id));
            }
            if (@class != null)
            {
                Attr(new Eighty.Attr("class", @class));
            }
            if (style != null)
            {
                Attr(new Eighty.Attr("style", style));
            }
            if (title != null)
            {
                Attr(new Eighty.Attr("title", title));
            }
            if (tabindex != null)
            {
                Attr(new Eighty.Attr("tabindex", tabindex));
            }
            if (contenteditable != null)
            {
                Attr(new Eighty.Attr("contenteditable", contenteditable));
            }
            if (dir != null)
            {
                Attr(new Eighty.Attr("dir", dir));
            }
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder bdo(params Attr[] attrs)
        {
            StartTagRaw("bdo");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        protected TagBuilder bdo(IEnumerable<Attr> attrs)
        {
            StartTagRaw("bdo");
            Attrs(attrs);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }
        
        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1)
        {
            StartTagRaw("bdo");
            Attrs(attr1);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1, Attr attr2)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        [NoDoc]
        protected TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            Writer.WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }
    }
}
#endregion
