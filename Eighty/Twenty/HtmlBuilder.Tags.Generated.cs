#region GeneratedCode
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Eighty.Twenty
{
    public abstract partial class HtmlBuilder
    {
        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable html(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable html(params Attr[] attrs)
        {
            StartTagRaw("html");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable html(IEnumerable<Attr> attrs)
        {
            StartTagRaw("html");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }
        
        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1)
        {
            StartTagRaw("html");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1, Attr attr2)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("html", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable head(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable head(params Attr[] attrs)
        {
            StartTagRaw("head");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable head(IEnumerable<Attr> attrs)
        {
            StartTagRaw("head");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }
        
        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1)
        {
            StartTagRaw("head");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1, Attr attr2)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("head", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable body(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable body(params Attr[] attrs)
        {
            StartTagRaw("body");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable body(IEnumerable<Attr> attrs)
        {
            StartTagRaw("body");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }
        
        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1)
        {
            StartTagRaw("body");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1, Attr attr2)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("body", this, false);
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        protected void link(params Attr[] attrs)
        {
            StartTagRaw("link");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        protected void link(IEnumerable<Attr> attrs)
        {
            StartTagRaw("link");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1)
        {
            StartTagRaw("link");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        [NoDoc]
        protected void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        protected void @base(params Attr[] attrs)
        {
            StartTagRaw("base");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        protected void @base(IEnumerable<Attr> attrs)
        {
            StartTagRaw("base");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1)
        {
            StartTagRaw("base");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        [NoDoc]
        protected void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        protected void meta(params Attr[] attrs)
        {
            StartTagRaw("meta");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        protected void meta(IEnumerable<Attr> attrs)
        {
            StartTagRaw("meta");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1)
        {
            StartTagRaw("meta");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        [NoDoc]
        protected void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable style(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable style(params Attr[] attrs)
        {
            StartTagRaw("style");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable style(IEnumerable<Attr> attrs)
        {
            StartTagRaw("style");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }
        
        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1)
        {
            StartTagRaw("style");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1, Attr attr2)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("style", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable title(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable title(params Attr[] attrs)
        {
            StartTagRaw("title");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable title(IEnumerable<Attr> attrs)
        {
            StartTagRaw("title");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }
        
        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1)
        {
            StartTagRaw("title");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1, Attr attr2)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("title", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable script(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable script(params Attr[] attrs)
        {
            StartTagRaw("script");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable script(IEnumerable<Attr> attrs)
        {
            StartTagRaw("script");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }
        
        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1)
        {
            StartTagRaw("script");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1, Attr attr2)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("script", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable noscript(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable noscript(params Attr[] attrs)
        {
            StartTagRaw("noscript");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable noscript(IEnumerable<Attr> attrs)
        {
            StartTagRaw("noscript");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }
        
        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1)
        {
            StartTagRaw("noscript");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1, Attr attr2)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("noscript", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable main(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable main(params Attr[] attrs)
        {
            StartTagRaw("main");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable main(IEnumerable<Attr> attrs)
        {
            StartTagRaw("main");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }
        
        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1)
        {
            StartTagRaw("main");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1, Attr attr2)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("main", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable header(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable header(params Attr[] attrs)
        {
            StartTagRaw("header");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable header(IEnumerable<Attr> attrs)
        {
            StartTagRaw("header");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }
        
        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1)
        {
            StartTagRaw("header");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1, Attr attr2)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("header", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable article(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable article(params Attr[] attrs)
        {
            StartTagRaw("article");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable article(IEnumerable<Attr> attrs)
        {
            StartTagRaw("article");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }
        
        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1)
        {
            StartTagRaw("article");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1, Attr attr2)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("article", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable section(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable section(params Attr[] attrs)
        {
            StartTagRaw("section");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable section(IEnumerable<Attr> attrs)
        {
            StartTagRaw("section");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }
        
        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1)
        {
            StartTagRaw("section");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1, Attr attr2)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("section", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable footer(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable footer(params Attr[] attrs)
        {
            StartTagRaw("footer");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable footer(IEnumerable<Attr> attrs)
        {
            StartTagRaw("footer");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }
        
        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1)
        {
            StartTagRaw("footer");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1, Attr attr2)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("footer", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h1(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h1(params Attr[] attrs)
        {
            StartTagRaw("h1");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h1(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h1");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }
        
        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1)
        {
            StartTagRaw("h1");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1, Attr attr2)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h1", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h2(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h2(params Attr[] attrs)
        {
            StartTagRaw("h2");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h2(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h2");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }
        
        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1)
        {
            StartTagRaw("h2");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1, Attr attr2)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h2", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h3(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h3(params Attr[] attrs)
        {
            StartTagRaw("h3");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h3(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h3");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }
        
        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1)
        {
            StartTagRaw("h3");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1, Attr attr2)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h3", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h4(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h4(params Attr[] attrs)
        {
            StartTagRaw("h4");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h4(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h4");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }
        
        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1)
        {
            StartTagRaw("h4");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1, Attr attr2)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h4", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h5(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h5(params Attr[] attrs)
        {
            StartTagRaw("h5");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h5(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h5");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }
        
        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1)
        {
            StartTagRaw("h5");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1, Attr attr2)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h5", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h6(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h6(params Attr[] attrs)
        {
            StartTagRaw("h6");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable h6(IEnumerable<Attr> attrs)
        {
            StartTagRaw("h6");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }
        
        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1)
        {
            StartTagRaw("h6");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1, Attr attr2)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("h6", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable hgroup(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable hgroup(params Attr[] attrs)
        {
            StartTagRaw("hgroup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable hgroup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("hgroup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }
        
        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1)
        {
            StartTagRaw("hgroup");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1, Attr attr2)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("hgroup", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable div(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable div(params Attr[] attrs)
        {
            StartTagRaw("div");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable div(IEnumerable<Attr> attrs)
        {
            StartTagRaw("div");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }
        
        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1)
        {
            StartTagRaw("div");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1, Attr attr2)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("div", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable p(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable p(params Attr[] attrs)
        {
            StartTagRaw("p");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable p(IEnumerable<Attr> attrs)
        {
            StartTagRaw("p");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }
        
        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1)
        {
            StartTagRaw("p");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1, Attr attr2)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("p", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable pre(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable pre(params Attr[] attrs)
        {
            StartTagRaw("pre");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable pre(IEnumerable<Attr> attrs)
        {
            StartTagRaw("pre");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }
        
        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1)
        {
            StartTagRaw("pre");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1, Attr attr2)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("pre", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable blockquote(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable blockquote(params Attr[] attrs)
        {
            StartTagRaw("blockquote");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable blockquote(IEnumerable<Attr> attrs)
        {
            StartTagRaw("blockquote");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }
        
        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1)
        {
            StartTagRaw("blockquote");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1, Attr attr2)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("blockquote", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable figure(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable figure(params Attr[] attrs)
        {
            StartTagRaw("figure");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable figure(IEnumerable<Attr> attrs)
        {
            StartTagRaw("figure");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }
        
        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1)
        {
            StartTagRaw("figure");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1, Attr attr2)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figure", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable figcaption(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable figcaption(params Attr[] attrs)
        {
            StartTagRaw("figcaption");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable figcaption(IEnumerable<Attr> attrs)
        {
            StartTagRaw("figcaption");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }
        
        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1)
        {
            StartTagRaw("figcaption");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1, Attr attr2)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("figcaption", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable aside(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable aside(params Attr[] attrs)
        {
            StartTagRaw("aside");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable aside(IEnumerable<Attr> attrs)
        {
            StartTagRaw("aside");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }
        
        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1)
        {
            StartTagRaw("aside");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1, Attr attr2)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("aside", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable nav(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable nav(params Attr[] attrs)
        {
            StartTagRaw("nav");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable nav(IEnumerable<Attr> attrs)
        {
            StartTagRaw("nav");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }
        
        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1)
        {
            StartTagRaw("nav");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1, Attr attr2)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("nav", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable address(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable address(params Attr[] attrs)
        {
            StartTagRaw("address");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable address(IEnumerable<Attr> attrs)
        {
            StartTagRaw("address");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }
        
        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1)
        {
            StartTagRaw("address");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1, Attr attr2)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("address", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable a(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable a(params Attr[] attrs)
        {
            StartTagRaw("a");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable a(IEnumerable<Attr> attrs)
        {
            StartTagRaw("a");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }
        
        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1)
        {
            StartTagRaw("a");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1, Attr attr2)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("a", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable b(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable b(params Attr[] attrs)
        {
            StartTagRaw("b");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable b(IEnumerable<Attr> attrs)
        {
            StartTagRaw("b");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }
        
        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1)
        {
            StartTagRaw("b");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1, Attr attr2)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("b", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable em(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable em(params Attr[] attrs)
        {
            StartTagRaw("em");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable em(IEnumerable<Attr> attrs)
        {
            StartTagRaw("em");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }
        
        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1)
        {
            StartTagRaw("em");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1, Attr attr2)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("em", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable i(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable i(params Attr[] attrs)
        {
            StartTagRaw("i");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable i(IEnumerable<Attr> attrs)
        {
            StartTagRaw("i");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }
        
        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1)
        {
            StartTagRaw("i");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1, Attr attr2)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("i", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable mark(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable mark(params Attr[] attrs)
        {
            StartTagRaw("mark");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable mark(IEnumerable<Attr> attrs)
        {
            StartTagRaw("mark");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }
        
        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1)
        {
            StartTagRaw("mark");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1, Attr attr2)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("mark", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable q(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable q(params Attr[] attrs)
        {
            StartTagRaw("q");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable q(IEnumerable<Attr> attrs)
        {
            StartTagRaw("q");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }
        
        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1)
        {
            StartTagRaw("q");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1, Attr attr2)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("q", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable s(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable s(params Attr[] attrs)
        {
            StartTagRaw("s");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable s(IEnumerable<Attr> attrs)
        {
            StartTagRaw("s");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }
        
        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1)
        {
            StartTagRaw("s");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1, Attr attr2)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("s", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable small(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable small(params Attr[] attrs)
        {
            StartTagRaw("small");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable small(IEnumerable<Attr> attrs)
        {
            StartTagRaw("small");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }
        
        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1)
        {
            StartTagRaw("small");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1, Attr attr2)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("small", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable span(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable span(params Attr[] attrs)
        {
            StartTagRaw("span");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable span(IEnumerable<Attr> attrs)
        {
            StartTagRaw("span");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }
        
        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1)
        {
            StartTagRaw("span");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1, Attr attr2)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("span", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable strong(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable strong(params Attr[] attrs)
        {
            StartTagRaw("strong");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable strong(IEnumerable<Attr> attrs)
        {
            StartTagRaw("strong");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }
        
        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1)
        {
            StartTagRaw("strong");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1, Attr attr2)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("strong", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable sub(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable sub(params Attr[] attrs)
        {
            StartTagRaw("sub");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable sub(IEnumerable<Attr> attrs)
        {
            StartTagRaw("sub");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }
        
        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1)
        {
            StartTagRaw("sub");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1, Attr attr2)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sub", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable sup(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable sup(params Attr[] attrs)
        {
            StartTagRaw("sup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable sup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("sup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }
        
        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1)
        {
            StartTagRaw("sup");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1, Attr attr2)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("sup", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable u(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable u(params Attr[] attrs)
        {
            StartTagRaw("u");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable u(IEnumerable<Attr> attrs)
        {
            StartTagRaw("u");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }
        
        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1)
        {
            StartTagRaw("u");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1, Attr attr2)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("u", this, false);
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        protected void br(params Attr[] attrs)
        {
            StartTagRaw("br");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        protected void br(IEnumerable<Attr> attrs)
        {
            StartTagRaw("br");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1)
        {
            StartTagRaw("br");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        [NoDoc]
        protected void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        protected void wbr(params Attr[] attrs)
        {
            StartTagRaw("wbr");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        protected void wbr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("wbr");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1)
        {
            StartTagRaw("wbr");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        [NoDoc]
        protected void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        protected void hr(params Attr[] attrs)
        {
            StartTagRaw("hr");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        protected void hr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("hr");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1)
        {
            StartTagRaw("hr");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        [NoDoc]
        protected void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable abbr(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable abbr(params Attr[] attrs)
        {
            StartTagRaw("abbr");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable abbr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("abbr");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }
        
        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1)
        {
            StartTagRaw("abbr");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1, Attr attr2)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("abbr", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable cite(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable cite(params Attr[] attrs)
        {
            StartTagRaw("cite");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable cite(IEnumerable<Attr> attrs)
        {
            StartTagRaw("cite");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }
        
        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1)
        {
            StartTagRaw("cite");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1, Attr attr2)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("cite", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable code(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable code(params Attr[] attrs)
        {
            StartTagRaw("code");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable code(IEnumerable<Attr> attrs)
        {
            StartTagRaw("code");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }
        
        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1)
        {
            StartTagRaw("code");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1, Attr attr2)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("code", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable data(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable data(params Attr[] attrs)
        {
            StartTagRaw("data");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable data(IEnumerable<Attr> attrs)
        {
            StartTagRaw("data");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }
        
        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1)
        {
            StartTagRaw("data");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1, Attr attr2)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("data", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dfn(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dfn(params Attr[] attrs)
        {
            StartTagRaw("dfn");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dfn(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dfn");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }
        
        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1)
        {
            StartTagRaw("dfn");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1, Attr attr2)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dfn", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable kbd(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable kbd(params Attr[] attrs)
        {
            StartTagRaw("kbd");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable kbd(IEnumerable<Attr> attrs)
        {
            StartTagRaw("kbd");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }
        
        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1)
        {
            StartTagRaw("kbd");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1, Attr attr2)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("kbd", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable samp(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable samp(params Attr[] attrs)
        {
            StartTagRaw("samp");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable samp(IEnumerable<Attr> attrs)
        {
            StartTagRaw("samp");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }
        
        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1)
        {
            StartTagRaw("samp");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1, Attr attr2)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("samp", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable time(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable time(params Attr[] attrs)
        {
            StartTagRaw("time");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable time(IEnumerable<Attr> attrs)
        {
            StartTagRaw("time");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }
        
        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1)
        {
            StartTagRaw("time");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1, Attr attr2)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("time", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable ol(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable ol(params Attr[] attrs)
        {
            StartTagRaw("ol");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable ol(IEnumerable<Attr> attrs)
        {
            StartTagRaw("ol");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }
        
        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1)
        {
            StartTagRaw("ol");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1, Attr attr2)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ol", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable ul(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable ul(params Attr[] attrs)
        {
            StartTagRaw("ul");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable ul(IEnumerable<Attr> attrs)
        {
            StartTagRaw("ul");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }
        
        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1)
        {
            StartTagRaw("ul");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1, Attr attr2)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("ul", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable li(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable li(params Attr[] attrs)
        {
            StartTagRaw("li");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable li(IEnumerable<Attr> attrs)
        {
            StartTagRaw("li");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }
        
        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1)
        {
            StartTagRaw("li");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1, Attr attr2)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("li", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dl(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dl(params Attr[] attrs)
        {
            StartTagRaw("dl");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dl(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dl");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }
        
        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1)
        {
            StartTagRaw("dl");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1, Attr attr2)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dl", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dt(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dt(params Attr[] attrs)
        {
            StartTagRaw("dt");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dt(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dt");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }
        
        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1)
        {
            StartTagRaw("dt");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1, Attr attr2)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dt", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dd(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dd(params Attr[] attrs)
        {
            StartTagRaw("dd");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dd(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dd");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }
        
        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1)
        {
            StartTagRaw("dd");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1, Attr attr2)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dd", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable table(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable table(params Attr[] attrs)
        {
            StartTagRaw("table");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable table(IEnumerable<Attr> attrs)
        {
            StartTagRaw("table");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }
        
        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1)
        {
            StartTagRaw("table");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1, Attr attr2)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("table", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable caption(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable caption(params Attr[] attrs)
        {
            StartTagRaw("caption");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable caption(IEnumerable<Attr> attrs)
        {
            StartTagRaw("caption");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }
        
        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1)
        {
            StartTagRaw("caption");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1, Attr attr2)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("caption", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable thead(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable thead(params Attr[] attrs)
        {
            StartTagRaw("thead");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable thead(IEnumerable<Attr> attrs)
        {
            StartTagRaw("thead");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }
        
        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1)
        {
            StartTagRaw("thead");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1, Attr attr2)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("thead", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable colgroup(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable colgroup(params Attr[] attrs)
        {
            StartTagRaw("colgroup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable colgroup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("colgroup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }
        
        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1)
        {
            StartTagRaw("colgroup");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1, Attr attr2)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("colgroup", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable col(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable col(params Attr[] attrs)
        {
            StartTagRaw("col");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable col(IEnumerable<Attr> attrs)
        {
            StartTagRaw("col");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }
        
        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1)
        {
            StartTagRaw("col");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1, Attr attr2)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("col", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tbody(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tbody(params Attr[] attrs)
        {
            StartTagRaw("tbody");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tbody(IEnumerable<Attr> attrs)
        {
            StartTagRaw("tbody");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }
        
        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1)
        {
            StartTagRaw("tbody");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1, Attr attr2)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tbody", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tr(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tr(params Attr[] attrs)
        {
            StartTagRaw("tr");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tr(IEnumerable<Attr> attrs)
        {
            StartTagRaw("tr");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }
        
        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1)
        {
            StartTagRaw("tr");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1, Attr attr2)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tr", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable th(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable th(params Attr[] attrs)
        {
            StartTagRaw("th");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable th(IEnumerable<Attr> attrs)
        {
            StartTagRaw("th");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }
        
        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1)
        {
            StartTagRaw("th");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1, Attr attr2)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("th", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable td(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable td(params Attr[] attrs)
        {
            StartTagRaw("td");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable td(IEnumerable<Attr> attrs)
        {
            StartTagRaw("td");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }
        
        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1)
        {
            StartTagRaw("td");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1, Attr attr2)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("td", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tfoot(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tfoot(params Attr[] attrs)
        {
            StartTagRaw("tfoot");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable tfoot(IEnumerable<Attr> attrs)
        {
            StartTagRaw("tfoot");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }
        
        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1)
        {
            StartTagRaw("tfoot");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1, Attr attr2)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("tfoot", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable form(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable form(params Attr[] attrs)
        {
            StartTagRaw("form");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable form(IEnumerable<Attr> attrs)
        {
            StartTagRaw("form");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }
        
        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1)
        {
            StartTagRaw("form");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1, Attr attr2)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("form", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable fieldset(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable fieldset(params Attr[] attrs)
        {
            StartTagRaw("fieldset");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable fieldset(IEnumerable<Attr> attrs)
        {
            StartTagRaw("fieldset");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }
        
        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1)
        {
            StartTagRaw("fieldset");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1, Attr attr2)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("fieldset", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable label(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable label(params Attr[] attrs)
        {
            StartTagRaw("label");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable label(IEnumerable<Attr> attrs)
        {
            StartTagRaw("label");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }
        
        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1)
        {
            StartTagRaw("label");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1, Attr attr2)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("label", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable input(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable input(params Attr[] attrs)
        {
            StartTagRaw("input");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable input(IEnumerable<Attr> attrs)
        {
            StartTagRaw("input");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }
        
        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1)
        {
            StartTagRaw("input");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1, Attr attr2)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("input", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable button(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable button(params Attr[] attrs)
        {
            StartTagRaw("button");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable button(IEnumerable<Attr> attrs)
        {
            StartTagRaw("button");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }
        
        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1)
        {
            StartTagRaw("button");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1, Attr attr2)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("button", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable textarea(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable textarea(params Attr[] attrs)
        {
            StartTagRaw("textarea");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable textarea(IEnumerable<Attr> attrs)
        {
            StartTagRaw("textarea");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }
        
        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1)
        {
            StartTagRaw("textarea");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1, Attr attr2)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("textarea", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable datalist(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable datalist(params Attr[] attrs)
        {
            StartTagRaw("datalist");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable datalist(IEnumerable<Attr> attrs)
        {
            StartTagRaw("datalist");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }
        
        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1)
        {
            StartTagRaw("datalist");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1, Attr attr2)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("datalist", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable optgroup(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable optgroup(params Attr[] attrs)
        {
            StartTagRaw("optgroup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable optgroup(IEnumerable<Attr> attrs)
        {
            StartTagRaw("optgroup");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }
        
        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1)
        {
            StartTagRaw("optgroup");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1, Attr attr2)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("optgroup", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable select(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable select(params Attr[] attrs)
        {
            StartTagRaw("select");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable select(IEnumerable<Attr> attrs)
        {
            StartTagRaw("select");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }
        
        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1)
        {
            StartTagRaw("select");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1, Attr attr2)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("select", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable option(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable option(params Attr[] attrs)
        {
            StartTagRaw("option");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable option(IEnumerable<Attr> attrs)
        {
            StartTagRaw("option");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }
        
        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1)
        {
            StartTagRaw("option");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1, Attr attr2)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("option", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable legend(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable legend(params Attr[] attrs)
        {
            StartTagRaw("legend");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable legend(IEnumerable<Attr> attrs)
        {
            StartTagRaw("legend");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }
        
        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1)
        {
            StartTagRaw("legend");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1, Attr attr2)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("legend", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable meter(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable meter(params Attr[] attrs)
        {
            StartTagRaw("meter");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable meter(IEnumerable<Attr> attrs)
        {
            StartTagRaw("meter");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }
        
        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1)
        {
            StartTagRaw("meter");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1, Attr attr2)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("meter", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable output(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable output(params Attr[] attrs)
        {
            StartTagRaw("output");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable output(IEnumerable<Attr> attrs)
        {
            StartTagRaw("output");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }
        
        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1)
        {
            StartTagRaw("output");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1, Attr attr2)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("output", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable progress(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable progress(params Attr[] attrs)
        {
            StartTagRaw("progress");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable progress(IEnumerable<Attr> attrs)
        {
            StartTagRaw("progress");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }
        
        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1)
        {
            StartTagRaw("progress");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1, Attr attr2)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("progress", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable menu(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable menu(params Attr[] attrs)
        {
            StartTagRaw("menu");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable menu(IEnumerable<Attr> attrs)
        {
            StartTagRaw("menu");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }
        
        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1)
        {
            StartTagRaw("menu");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1, Attr attr2)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menu", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable menuitem(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable menuitem(params Attr[] attrs)
        {
            StartTagRaw("menuitem");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable menuitem(IEnumerable<Attr> attrs)
        {
            StartTagRaw("menuitem");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }
        
        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1)
        {
            StartTagRaw("menuitem");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1, Attr attr2)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("menuitem", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dialog(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dialog(params Attr[] attrs)
        {
            StartTagRaw("dialog");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable dialog(IEnumerable<Attr> attrs)
        {
            StartTagRaw("dialog");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }
        
        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1)
        {
            StartTagRaw("dialog");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1, Attr attr2)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("dialog", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable details(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable details(params Attr[] attrs)
        {
            StartTagRaw("details");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable details(IEnumerable<Attr> attrs)
        {
            StartTagRaw("details");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }
        
        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1)
        {
            StartTagRaw("details");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1, Attr attr2)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("details", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable summary(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable summary(params Attr[] attrs)
        {
            StartTagRaw("summary");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable summary(IEnumerable<Attr> attrs)
        {
            StartTagRaw("summary");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }
        
        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1)
        {
            StartTagRaw("summary");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1, Attr attr2)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("summary", this, false);
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        protected void img(params Attr[] attrs)
        {
            StartTagRaw("img");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        protected void img(IEnumerable<Attr> attrs)
        {
            StartTagRaw("img");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1)
        {
            StartTagRaw("img");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        [NoDoc]
        protected void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable audio(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable audio(params Attr[] attrs)
        {
            StartTagRaw("audio");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable audio(IEnumerable<Attr> attrs)
        {
            StartTagRaw("audio");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }
        
        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1)
        {
            StartTagRaw("audio");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1, Attr attr2)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("audio", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable video(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable video(params Attr[] attrs)
        {
            StartTagRaw("video");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable video(IEnumerable<Attr> attrs)
        {
            StartTagRaw("video");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }
        
        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1)
        {
            StartTagRaw("video");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1, Attr attr2)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("video", this, false);
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        protected void track(params Attr[] attrs)
        {
            StartTagRaw("track");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        protected void track(IEnumerable<Attr> attrs)
        {
            StartTagRaw("track");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1)
        {
            StartTagRaw("track");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        [NoDoc]
        protected void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        protected void embed(params Attr[] attrs)
        {
            StartTagRaw("embed");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        protected void embed(IEnumerable<Attr> attrs)
        {
            StartTagRaw("embed");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1)
        {
            StartTagRaw("embed");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        [NoDoc]
        protected void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable @object(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable @object(params Attr[] attrs)
        {
            StartTagRaw("object");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable @object(IEnumerable<Attr> attrs)
        {
            StartTagRaw("object");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }
        
        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1)
        {
            StartTagRaw("object");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1, Attr attr2)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("object", this, false);
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        protected void param(params Attr[] attrs)
        {
            StartTagRaw("param");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        protected void param(IEnumerable<Attr> attrs)
        {
            StartTagRaw("param");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1)
        {
            StartTagRaw("param");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        [NoDoc]
        protected void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable picture(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable picture(params Attr[] attrs)
        {
            StartTagRaw("picture");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable picture(IEnumerable<Attr> attrs)
        {
            StartTagRaw("picture");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }
        
        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1)
        {
            StartTagRaw("picture");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1, Attr attr2)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("picture", this, false);
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
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
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        protected void source(params Attr[] attrs)
        {
            StartTagRaw("source");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        protected void source(IEnumerable<Attr> attrs)
        {
            StartTagRaw("source");
            Attrs(attrs);
            _writer.Get().WriteRaw("/>");
        }
        
        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1)
        {
            StartTagRaw("source");
            Attrs(attr1);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        [NoDoc]
        protected void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw("/>");
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable canvas(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable canvas(params Attr[] attrs)
        {
            StartTagRaw("canvas");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable canvas(IEnumerable<Attr> attrs)
        {
            StartTagRaw("canvas");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }
        
        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1)
        {
            StartTagRaw("canvas");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1, Attr attr2)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("canvas", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable bdi(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable bdi(params Attr[] attrs)
        {
            StartTagRaw("bdi");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable bdi(IEnumerable<Attr> attrs)
        {
            StartTagRaw("bdi");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }
        
        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1)
        {
            StartTagRaw("bdi");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1, Attr attr2)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdi", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable bdo(
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
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable bdo(params Attr[] attrs)
        {
            StartTagRaw("bdo");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        protected IDisposable bdo(IEnumerable<Attr> attrs)
        {
            StartTagRaw("bdo");
            Attrs(attrs);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }
        
        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1)
        {
            StartTagRaw("bdo");
            Attrs(attr1);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1, Attr attr2)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="IDisposable"/> which MUST be disposed immediately after the children have been written</returns>
        [NoDoc]
        protected IDisposable bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTagRaw("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Get().WriteRaw('>');
            return new TagBuilder("bdo", this, false);
        }
    }
}
#endregion
