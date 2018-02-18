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
        public TagBuilder html(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string xmlns = null
        )
        {
            StartTag("html");
            
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
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(params Attr[] attrs)
        {
            StartTag("html");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(IEnumerable<Attr> attrs)
        {
            StartTag("html");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }
        
        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1)
        {
            StartTag("html");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1, Attr attr2)
        {
            StartTag("html");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("html");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("html");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("html");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write an html element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder html(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("html");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("html", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("head");
            
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
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(params Attr[] attrs)
        {
            StartTag("head");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(IEnumerable<Attr> attrs)
        {
            StartTag("head");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }
        
        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1)
        {
            StartTag("head");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1, Attr attr2)
        {
            StartTag("head");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("head");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("head");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("head");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a head element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder head(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("head");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("head", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("body");
            
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
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(params Attr[] attrs)
        {
            StartTag("body");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(IEnumerable<Attr> attrs)
        {
            StartTag("body");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }
        
        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1)
        {
            StartTag("body");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1, Attr attr2)
        {
            StartTag("body");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("body");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("body");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("body");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a body element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder body(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("body");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("body", _writer);
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(
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
            StartTag("link");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(params Attr[] attrs)
        {
            StartTag("link");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(IEnumerable<Attr> attrs)
        {
            StartTag("link");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1)
        {
            StartTag("link");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1, Attr attr2)
        {
            StartTag("link");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("link");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("link");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("link");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a link element.
        /// </summary>
        public void link(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("link");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(
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
            StartTag("base");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(params Attr[] attrs)
        {
            StartTag("base");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(IEnumerable<Attr> attrs)
        {
            StartTag("base");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1)
        {
            StartTag("base");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1, Attr attr2)
        {
            StartTag("base");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("base");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("base");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("base");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a base element.
        /// </summary>
        public void @base(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("base");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(
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
            StartTag("meta");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(params Attr[] attrs)
        {
            StartTag("meta");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(IEnumerable<Attr> attrs)
        {
            StartTag("meta");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1)
        {
            StartTag("meta");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1, Attr attr2)
        {
            StartTag("meta");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("meta");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("meta");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a meta element.
        /// </summary>
        public void meta(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("meta");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(
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
            StartTag("style");
            
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
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(params Attr[] attrs)
        {
            StartTag("style");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(IEnumerable<Attr> attrs)
        {
            StartTag("style");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }
        
        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1)
        {
            StartTag("style");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1, Attr attr2)
        {
            StartTag("style");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("style");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("style");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("style");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a style element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder style(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("style");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("style", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("title");
            
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
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(params Attr[] attrs)
        {
            StartTag("title");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(IEnumerable<Attr> attrs)
        {
            StartTag("title");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }
        
        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1)
        {
            StartTag("title");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1, Attr attr2)
        {
            StartTag("title");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("title");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("title");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("title");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a title element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder title(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("title");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("title", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(
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
            StartTag("script");
            
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
                Attr(new Eighty.Attr("async"));
            }
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(params Attr[] attrs)
        {
            StartTag("script");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(IEnumerable<Attr> attrs)
        {
            StartTag("script");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }
        
        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1)
        {
            StartTag("script");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1, Attr attr2)
        {
            StartTag("script");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("script");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("script");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("script");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a script element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder script(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("script");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("script", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("noscript");
            
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
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(params Attr[] attrs)
        {
            StartTag("noscript");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(IEnumerable<Attr> attrs)
        {
            StartTag("noscript");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }
        
        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1)
        {
            StartTag("noscript");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1, Attr attr2)
        {
            StartTag("noscript");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("noscript");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("noscript");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a noscript element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder noscript(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("noscript");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("noscript", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("main");
            
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
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(params Attr[] attrs)
        {
            StartTag("main");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(IEnumerable<Attr> attrs)
        {
            StartTag("main");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }
        
        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1)
        {
            StartTag("main");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1, Attr attr2)
        {
            StartTag("main");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("main");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("main");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("main");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a main element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder main(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("main");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("main", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("header");
            
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
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(params Attr[] attrs)
        {
            StartTag("header");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(IEnumerable<Attr> attrs)
        {
            StartTag("header");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }
        
        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1)
        {
            StartTag("header");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1, Attr attr2)
        {
            StartTag("header");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("header");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("header");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("header");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write a header element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder header(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("header");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("header", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("article");
            
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
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(params Attr[] attrs)
        {
            StartTag("article");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(IEnumerable<Attr> attrs)
        {
            StartTag("article");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }
        
        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1)
        {
            StartTag("article");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1, Attr attr2)
        {
            StartTag("article");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("article");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("article");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("article");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write an article element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder article(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("article");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("article", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("section");
            
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
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(params Attr[] attrs)
        {
            StartTag("section");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(IEnumerable<Attr> attrs)
        {
            StartTag("section");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }
        
        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1)
        {
            StartTag("section");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1, Attr attr2)
        {
            StartTag("section");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("section");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("section");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("section");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a section element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder section(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("section");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("section", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("footer");
            
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
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(params Attr[] attrs)
        {
            StartTag("footer");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(IEnumerable<Attr> attrs)
        {
            StartTag("footer");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }
        
        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1)
        {
            StartTag("footer");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1, Attr attr2)
        {
            StartTag("footer");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("footer");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("footer");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write a footer element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder footer(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("footer");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("footer", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("h1");
            
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
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(params Attr[] attrs)
        {
            StartTag("h1");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(IEnumerable<Attr> attrs)
        {
            StartTag("h1");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }
        
        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1)
        {
            StartTag("h1");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1, Attr attr2)
        {
            StartTag("h1");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("h1");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("h1");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h1 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h1(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("h1");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("h1", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("h2");
            
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
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(params Attr[] attrs)
        {
            StartTag("h2");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(IEnumerable<Attr> attrs)
        {
            StartTag("h2");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }
        
        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1)
        {
            StartTag("h2");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1, Attr attr2)
        {
            StartTag("h2");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("h2");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("h2");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h2 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h2(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("h2");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("h2", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("h3");
            
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
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(params Attr[] attrs)
        {
            StartTag("h3");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(IEnumerable<Attr> attrs)
        {
            StartTag("h3");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }
        
        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1)
        {
            StartTag("h3");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1, Attr attr2)
        {
            StartTag("h3");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("h3");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("h3");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h3 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h3(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("h3");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("h3", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("h4");
            
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
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(params Attr[] attrs)
        {
            StartTag("h4");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(IEnumerable<Attr> attrs)
        {
            StartTag("h4");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }
        
        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1)
        {
            StartTag("h4");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1, Attr attr2)
        {
            StartTag("h4");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("h4");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("h4");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h4 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h4(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("h4");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("h4", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("h5");
            
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
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(params Attr[] attrs)
        {
            StartTag("h5");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(IEnumerable<Attr> attrs)
        {
            StartTag("h5");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }
        
        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1)
        {
            StartTag("h5");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1, Attr attr2)
        {
            StartTag("h5");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("h5");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("h5");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h5 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h5(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("h5");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("h5", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("h6");
            
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
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(params Attr[] attrs)
        {
            StartTag("h6");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(IEnumerable<Attr> attrs)
        {
            StartTag("h6");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }
        
        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1)
        {
            StartTag("h6");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1, Attr attr2)
        {
            StartTag("h6");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("h6");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("h6");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write an h6 element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder h6(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("h6");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("h6", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("hgroup");
            
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
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(params Attr[] attrs)
        {
            StartTag("hgroup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(IEnumerable<Attr> attrs)
        {
            StartTag("hgroup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }
        
        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1)
        {
            StartTag("hgroup");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1, Attr attr2)
        {
            StartTag("hgroup");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("hgroup");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("hgroup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a hgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder hgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("hgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("hgroup", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("div");
            
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
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(params Attr[] attrs)
        {
            StartTag("div");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(IEnumerable<Attr> attrs)
        {
            StartTag("div");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }
        
        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1)
        {
            StartTag("div");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1, Attr attr2)
        {
            StartTag("div");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("div");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("div");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("div");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a div element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder div(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("div");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("div", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("p");
            
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
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(params Attr[] attrs)
        {
            StartTag("p");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(IEnumerable<Attr> attrs)
        {
            StartTag("p");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }
        
        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1)
        {
            StartTag("p");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1, Attr attr2)
        {
            StartTag("p");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("p");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("p");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("p");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a p element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder p(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("p");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("p", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("pre");
            
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
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(params Attr[] attrs)
        {
            StartTag("pre");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(IEnumerable<Attr> attrs)
        {
            StartTag("pre");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }
        
        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1)
        {
            StartTag("pre");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1, Attr attr2)
        {
            StartTag("pre");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("pre");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("pre");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a pre element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder pre(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("pre");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("pre", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("blockquote");
            
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
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(params Attr[] attrs)
        {
            StartTag("blockquote");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(IEnumerable<Attr> attrs)
        {
            StartTag("blockquote");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }
        
        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1)
        {
            StartTag("blockquote");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1, Attr attr2)
        {
            StartTag("blockquote");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("blockquote");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("blockquote");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a blockquote element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder blockquote(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("blockquote");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("blockquote", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("figure");
            
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
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(params Attr[] attrs)
        {
            StartTag("figure");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(IEnumerable<Attr> attrs)
        {
            StartTag("figure");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }
        
        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1)
        {
            StartTag("figure");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1, Attr attr2)
        {
            StartTag("figure");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("figure");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("figure");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figure element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figure(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("figure");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("figure", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("figcaption");
            
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
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(params Attr[] attrs)
        {
            StartTag("figcaption");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(IEnumerable<Attr> attrs)
        {
            StartTag("figcaption");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }
        
        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1)
        {
            StartTag("figcaption");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1, Attr attr2)
        {
            StartTag("figcaption");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("figcaption");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("figcaption");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write a figcaption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder figcaption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("figcaption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("figcaption", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("aside");
            
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
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(params Attr[] attrs)
        {
            StartTag("aside");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(IEnumerable<Attr> attrs)
        {
            StartTag("aside");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }
        
        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1)
        {
            StartTag("aside");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1, Attr attr2)
        {
            StartTag("aside");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("aside");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("aside");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write an aside element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder aside(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("aside");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("aside", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("nav");
            
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
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(params Attr[] attrs)
        {
            StartTag("nav");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(IEnumerable<Attr> attrs)
        {
            StartTag("nav");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }
        
        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1)
        {
            StartTag("nav");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1, Attr attr2)
        {
            StartTag("nav");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("nav");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("nav");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write a nav element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder nav(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("nav");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("nav", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("address");
            
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
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(params Attr[] attrs)
        {
            StartTag("address");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(IEnumerable<Attr> attrs)
        {
            StartTag("address");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }
        
        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1)
        {
            StartTag("address");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1, Attr attr2)
        {
            StartTag("address");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("address");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("address");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("address");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an address element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder address(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("address");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("address", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(
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
            StartTag("a");
            
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
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(params Attr[] attrs)
        {
            StartTag("a");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(IEnumerable<Attr> attrs)
        {
            StartTag("a");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }
        
        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1)
        {
            StartTag("a");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1, Attr attr2)
        {
            StartTag("a");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("a");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("a");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("a");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write an a element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder a(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("a");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("a", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("b");
            
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
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(params Attr[] attrs)
        {
            StartTag("b");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(IEnumerable<Attr> attrs)
        {
            StartTag("b");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }
        
        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1)
        {
            StartTag("b");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1, Attr attr2)
        {
            StartTag("b");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("b");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("b");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("b");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write a b element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder b(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("b");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("b", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("em");
            
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
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(params Attr[] attrs)
        {
            StartTag("em");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(IEnumerable<Attr> attrs)
        {
            StartTag("em");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }
        
        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1)
        {
            StartTag("em");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1, Attr attr2)
        {
            StartTag("em");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("em");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("em");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("em");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an em element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder em(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("em");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("em", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("i");
            
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
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(params Attr[] attrs)
        {
            StartTag("i");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(IEnumerable<Attr> attrs)
        {
            StartTag("i");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }
        
        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1)
        {
            StartTag("i");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1, Attr attr2)
        {
            StartTag("i");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("i");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("i");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("i");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write an i element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder i(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("i");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("i", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("mark");
            
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
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(params Attr[] attrs)
        {
            StartTag("mark");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(IEnumerable<Attr> attrs)
        {
            StartTag("mark");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }
        
        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1)
        {
            StartTag("mark");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1, Attr attr2)
        {
            StartTag("mark");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("mark");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("mark");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a mark element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder mark(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("mark");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("mark", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string cite = null
        )
        {
            StartTag("q");
            
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
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(params Attr[] attrs)
        {
            StartTag("q");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(IEnumerable<Attr> attrs)
        {
            StartTag("q");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }
        
        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1)
        {
            StartTag("q");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1, Attr attr2)
        {
            StartTag("q");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("q");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("q");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("q");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write a q element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder q(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("q");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("q", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("s");
            
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
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(params Attr[] attrs)
        {
            StartTag("s");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(IEnumerable<Attr> attrs)
        {
            StartTag("s");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }
        
        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1)
        {
            StartTag("s");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1, Attr attr2)
        {
            StartTag("s");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("s");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("s");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("s");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write an s element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder s(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("s");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("s", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("small");
            
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
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(params Attr[] attrs)
        {
            StartTag("small");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(IEnumerable<Attr> attrs)
        {
            StartTag("small");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }
        
        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1)
        {
            StartTag("small");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1, Attr attr2)
        {
            StartTag("small");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("small");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("small");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("small");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a small element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder small(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("small");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("small", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("span");
            
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
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(params Attr[] attrs)
        {
            StartTag("span");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(IEnumerable<Attr> attrs)
        {
            StartTag("span");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }
        
        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1)
        {
            StartTag("span");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1, Attr attr2)
        {
            StartTag("span");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("span");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("span");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("span");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a span element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder span(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("span");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("span", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("strong");
            
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
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(params Attr[] attrs)
        {
            StartTag("strong");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(IEnumerable<Attr> attrs)
        {
            StartTag("strong");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }
        
        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1)
        {
            StartTag("strong");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1, Attr attr2)
        {
            StartTag("strong");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("strong");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("strong");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a strong element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder strong(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("strong");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("strong", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("sub");
            
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
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(params Attr[] attrs)
        {
            StartTag("sub");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(IEnumerable<Attr> attrs)
        {
            StartTag("sub");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }
        
        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1)
        {
            StartTag("sub");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1, Attr attr2)
        {
            StartTag("sub");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("sub");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("sub");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sub element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sub(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("sub");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("sub", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("sup");
            
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
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(params Attr[] attrs)
        {
            StartTag("sup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(IEnumerable<Attr> attrs)
        {
            StartTag("sup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }
        
        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1)
        {
            StartTag("sup");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1, Attr attr2)
        {
            StartTag("sup");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("sup");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("sup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write a sup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder sup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("sup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("sup", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("u");
            
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
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(params Attr[] attrs)
        {
            StartTag("u");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(IEnumerable<Attr> attrs)
        {
            StartTag("u");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }
        
        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1)
        {
            StartTag("u");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1, Attr attr2)
        {
            StartTag("u");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("u");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("u");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("u");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write an u element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder u(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("u");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("u", _writer);
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("br");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(params Attr[] attrs)
        {
            StartTag("br");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(IEnumerable<Attr> attrs)
        {
            StartTag("br");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1)
        {
            StartTag("br");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1, Attr attr2)
        {
            StartTag("br");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("br");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("br");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("br");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a br element.
        /// </summary>
        public void br(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("br");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("wbr");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(params Attr[] attrs)
        {
            StartTag("wbr");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(IEnumerable<Attr> attrs)
        {
            StartTag("wbr");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1)
        {
            StartTag("wbr");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1, Attr attr2)
        {
            StartTag("wbr");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("wbr");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("wbr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a wbr element.
        /// </summary>
        public void wbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("wbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("hr");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(params Attr[] attrs)
        {
            StartTag("hr");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(IEnumerable<Attr> attrs)
        {
            StartTag("hr");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1)
        {
            StartTag("hr");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1, Attr attr2)
        {
            StartTag("hr");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("hr");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("hr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an hr element.
        /// </summary>
        public void hr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("hr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("abbr");
            
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
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(params Attr[] attrs)
        {
            StartTag("abbr");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(IEnumerable<Attr> attrs)
        {
            StartTag("abbr");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }
        
        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1)
        {
            StartTag("abbr");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1, Attr attr2)
        {
            StartTag("abbr");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("abbr");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("abbr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write an abbr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder abbr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("abbr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("abbr", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("cite");
            
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
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(params Attr[] attrs)
        {
            StartTag("cite");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(IEnumerable<Attr> attrs)
        {
            StartTag("cite");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }
        
        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1)
        {
            StartTag("cite");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1, Attr attr2)
        {
            StartTag("cite");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("cite");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("cite");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a cite element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder cite(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("cite");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("cite", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("code");
            
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
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(params Attr[] attrs)
        {
            StartTag("code");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(IEnumerable<Attr> attrs)
        {
            StartTag("code");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }
        
        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1)
        {
            StartTag("code");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1, Attr attr2)
        {
            StartTag("code");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("code");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("code");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("code");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a code element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder code(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("code");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("code", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string value = null
        )
        {
            StartTag("data");
            
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
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(params Attr[] attrs)
        {
            StartTag("data");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(IEnumerable<Attr> attrs)
        {
            StartTag("data");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }
        
        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1)
        {
            StartTag("data");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1, Attr attr2)
        {
            StartTag("data");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("data");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("data");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("data");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a data element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder data(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("data");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("data", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("dfn");
            
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
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(params Attr[] attrs)
        {
            StartTag("dfn");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(IEnumerable<Attr> attrs)
        {
            StartTag("dfn");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }
        
        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1)
        {
            StartTag("dfn");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1, Attr attr2)
        {
            StartTag("dfn");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("dfn");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("dfn");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a dfn element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dfn(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("dfn");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("dfn", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("kbd");
            
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
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(params Attr[] attrs)
        {
            StartTag("kbd");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(IEnumerable<Attr> attrs)
        {
            StartTag("kbd");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }
        
        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1)
        {
            StartTag("kbd");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1, Attr attr2)
        {
            StartTag("kbd");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("kbd");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("kbd");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a kbd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder kbd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("kbd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("kbd", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("samp");
            
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
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(params Attr[] attrs)
        {
            StartTag("samp");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(IEnumerable<Attr> attrs)
        {
            StartTag("samp");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }
        
        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1)
        {
            StartTag("samp");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1, Attr attr2)
        {
            StartTag("samp");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("samp");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("samp");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a samp element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder samp(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("samp");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("samp", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string datetime = null
        )
        {
            StartTag("time");
            
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
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(params Attr[] attrs)
        {
            StartTag("time");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(IEnumerable<Attr> attrs)
        {
            StartTag("time");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }
        
        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1)
        {
            StartTag("time");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1, Attr attr2)
        {
            StartTag("time");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("time");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("time");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("time");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write a time element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder time(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("time");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("time", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(
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
            StartTag("ol");
            
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
                Attr(new Eighty.Attr("reversed"));
            }
            if (start != null)
            {
                Attr(new Eighty.Attr("start", start));
            }
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(params Attr[] attrs)
        {
            StartTag("ol");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(IEnumerable<Attr> attrs)
        {
            StartTag("ol");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }
        
        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1)
        {
            StartTag("ol");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1, Attr attr2)
        {
            StartTag("ol");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("ol");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("ol");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ol element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ol(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("ol");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("ol", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(
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
            StartTag("ul");
            
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
                Attr(new Eighty.Attr("reversed"));
            }
            if (start != null)
            {
                Attr(new Eighty.Attr("start", start));
            }
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(params Attr[] attrs)
        {
            StartTag("ul");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(IEnumerable<Attr> attrs)
        {
            StartTag("ul");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }
        
        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1)
        {
            StartTag("ul");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1, Attr attr2)
        {
            StartTag("ul");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("ul");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("ul");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an ul element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder ul(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("ul");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("ul", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string value = null
        )
        {
            StartTag("li");
            
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
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(params Attr[] attrs)
        {
            StartTag("li");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(IEnumerable<Attr> attrs)
        {
            StartTag("li");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }
        
        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1)
        {
            StartTag("li");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1, Attr attr2)
        {
            StartTag("li");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("li");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("li");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("li");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write an li element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder li(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("li");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("li", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("dl");
            
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
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(params Attr[] attrs)
        {
            StartTag("dl");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(IEnumerable<Attr> attrs)
        {
            StartTag("dl");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }
        
        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1)
        {
            StartTag("dl");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1, Attr attr2)
        {
            StartTag("dl");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("dl");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("dl");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dl element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dl(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("dl");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("dl", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("dt");
            
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
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(params Attr[] attrs)
        {
            StartTag("dt");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(IEnumerable<Attr> attrs)
        {
            StartTag("dt");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }
        
        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1)
        {
            StartTag("dt");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1, Attr attr2)
        {
            StartTag("dt");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("dt");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("dt");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dt element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dt(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("dt");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("dt", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("dd");
            
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
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(params Attr[] attrs)
        {
            StartTag("dd");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(IEnumerable<Attr> attrs)
        {
            StartTag("dd");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }
        
        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1)
        {
            StartTag("dd");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1, Attr attr2)
        {
            StartTag("dd");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("dd");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("dd");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a dd element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dd(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("dd");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("dd", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("table");
            
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
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(params Attr[] attrs)
        {
            StartTag("table");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(IEnumerable<Attr> attrs)
        {
            StartTag("table");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }
        
        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1)
        {
            StartTag("table");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1, Attr attr2)
        {
            StartTag("table");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("table");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("table");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("table");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a table element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder table(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("table");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("table", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("caption");
            
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
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(params Attr[] attrs)
        {
            StartTag("caption");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(IEnumerable<Attr> attrs)
        {
            StartTag("caption");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }
        
        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1)
        {
            StartTag("caption");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1, Attr attr2)
        {
            StartTag("caption");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("caption");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("caption");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a caption element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder caption(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("caption");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("caption", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("thead");
            
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
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(params Attr[] attrs)
        {
            StartTag("thead");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(IEnumerable<Attr> attrs)
        {
            StartTag("thead");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }
        
        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1)
        {
            StartTag("thead");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1, Attr attr2)
        {
            StartTag("thead");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("thead");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("thead");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a thead element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder thead(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("thead");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("thead", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string span = null
        )
        {
            StartTag("colgroup");
            
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
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(params Attr[] attrs)
        {
            StartTag("colgroup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(IEnumerable<Attr> attrs)
        {
            StartTag("colgroup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }
        
        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1)
        {
            StartTag("colgroup");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1, Attr attr2)
        {
            StartTag("colgroup");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("colgroup");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("colgroup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a colgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder colgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("colgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("colgroup", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string span = null
        )
        {
            StartTag("col");
            
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
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(params Attr[] attrs)
        {
            StartTag("col");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(IEnumerable<Attr> attrs)
        {
            StartTag("col");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }
        
        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1)
        {
            StartTag("col");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1, Attr attr2)
        {
            StartTag("col");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("col");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("col");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("col");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a col element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder col(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("col");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("col", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("tbody");
            
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
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(params Attr[] attrs)
        {
            StartTag("tbody");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(IEnumerable<Attr> attrs)
        {
            StartTag("tbody");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }
        
        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1)
        {
            StartTag("tbody");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1, Attr attr2)
        {
            StartTag("tbody");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("tbody");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("tbody");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tbody element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tbody(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("tbody");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("tbody", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("tr");
            
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
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(params Attr[] attrs)
        {
            StartTag("tr");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(IEnumerable<Attr> attrs)
        {
            StartTag("tr");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }
        
        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1)
        {
            StartTag("tr");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1, Attr attr2)
        {
            StartTag("tr");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("tr");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("tr");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a tr element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tr(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("tr");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("tr", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(
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
            StartTag("th");
            
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
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(params Attr[] attrs)
        {
            StartTag("th");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(IEnumerable<Attr> attrs)
        {
            StartTag("th");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }
        
        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1)
        {
            StartTag("th");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1, Attr attr2)
        {
            StartTag("th");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("th");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("th");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("th");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a th element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder th(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("th");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("th", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(
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
            StartTag("td");
            
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
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(params Attr[] attrs)
        {
            StartTag("td");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(IEnumerable<Attr> attrs)
        {
            StartTag("td");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }
        
        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1)
        {
            StartTag("td");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1, Attr attr2)
        {
            StartTag("td");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("td");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("td");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("td");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a td element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder td(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("td");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("td", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("tfoot");
            
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
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(params Attr[] attrs)
        {
            StartTag("tfoot");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(IEnumerable<Attr> attrs)
        {
            StartTag("tfoot");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }
        
        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1)
        {
            StartTag("tfoot");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1, Attr attr2)
        {
            StartTag("tfoot");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("tfoot");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("tfoot");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a tfoot element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder tfoot(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("tfoot");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("tfoot", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(
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
            StartTag("form");
            
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
                Attr(new Eighty.Attr("novalidate"));
            }
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(params Attr[] attrs)
        {
            StartTag("form");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(IEnumerable<Attr> attrs)
        {
            StartTag("form");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }
        
        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1)
        {
            StartTag("form");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1, Attr attr2)
        {
            StartTag("form");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("form");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("form");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("form");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a form element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder form(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("form");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("form", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(
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
            StartTag("fieldset");
            
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
                Attr(new Eighty.Attr("disabled"));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(params Attr[] attrs)
        {
            StartTag("fieldset");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(IEnumerable<Attr> attrs)
        {
            StartTag("fieldset");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }
        
        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1)
        {
            StartTag("fieldset");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1, Attr attr2)
        {
            StartTag("fieldset");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("fieldset");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("fieldset");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a fieldset element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder fieldset(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("fieldset");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("fieldset", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string @for = null
        )
        {
            StartTag("label");
            
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
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(params Attr[] attrs)
        {
            StartTag("label");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(IEnumerable<Attr> attrs)
        {
            StartTag("label");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }
        
        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1)
        {
            StartTag("label");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1, Attr attr2)
        {
            StartTag("label");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("label");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("label");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("label");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write a label element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder label(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("label");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("label", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(
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
            StartTag("input");
            
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
                Attr(new Eighty.Attr("autofocus"));
            }
            if (@checked)
            {
                Attr(new Eighty.Attr("checked"));
            }
            if (disabled)
            {
                Attr(new Eighty.Attr("disabled"));
            }
            if (@readonly)
            {
                Attr(new Eighty.Attr("readonly"));
            }
            if (required)
            {
                Attr(new Eighty.Attr("required"));
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
                Attr(new Eighty.Attr("formnovalidate"));
            }
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(params Attr[] attrs)
        {
            StartTag("input");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(IEnumerable<Attr> attrs)
        {
            StartTag("input");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }
        
        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1)
        {
            StartTag("input");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1, Attr attr2)
        {
            StartTag("input");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("input");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("input");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("input");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write an input element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder input(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("input");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("input", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(
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
            StartTag("button");
            
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
                Attr(new Eighty.Attr("autofocus"));
            }
            if (disabled)
            {
                Attr(new Eighty.Attr("disabled"));
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
                Attr(new Eighty.Attr("formnovalidate"));
            }
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(params Attr[] attrs)
        {
            StartTag("button");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(IEnumerable<Attr> attrs)
        {
            StartTag("button");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }
        
        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1)
        {
            StartTag("button");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1, Attr attr2)
        {
            StartTag("button");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("button");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("button");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("button");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a button element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder button(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("button");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("button", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(
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
            StartTag("textarea");
            
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
                Attr(new Eighty.Attr("autofocus"));
            }
            if (disabled)
            {
                Attr(new Eighty.Attr("disabled"));
            }
            if (@readonly)
            {
                Attr(new Eighty.Attr("readonly"));
            }
            if (required)
            {
                Attr(new Eighty.Attr("required"));
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
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(params Attr[] attrs)
        {
            StartTag("textarea");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(IEnumerable<Attr> attrs)
        {
            StartTag("textarea");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }
        
        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1)
        {
            StartTag("textarea");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1, Attr attr2)
        {
            StartTag("textarea");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("textarea");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("textarea");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a textarea element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder textarea(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("textarea");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("textarea", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("datalist");
            
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
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(params Attr[] attrs)
        {
            StartTag("datalist");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(IEnumerable<Attr> attrs)
        {
            StartTag("datalist");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }
        
        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1)
        {
            StartTag("datalist");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1, Attr attr2)
        {
            StartTag("datalist");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("datalist");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("datalist");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write a datalist element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder datalist(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("datalist");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("datalist", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(
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
            StartTag("optgroup");
            
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
                Attr(new Eighty.Attr("disabled"));
            }
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(params Attr[] attrs)
        {
            StartTag("optgroup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(IEnumerable<Attr> attrs)
        {
            StartTag("optgroup");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }
        
        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1)
        {
            StartTag("optgroup");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1, Attr attr2)
        {
            StartTag("optgroup");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("optgroup");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("optgroup");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write an optgroup element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder optgroup(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("optgroup");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("optgroup", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(
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
            StartTag("select");
            
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
                Attr(new Eighty.Attr("autofocus"));
            }
            if (disabled)
            {
                Attr(new Eighty.Attr("disabled"));
            }
            if (required)
            {
                Attr(new Eighty.Attr("required"));
            }
            if (form != null)
            {
                Attr(new Eighty.Attr("form", form));
            }
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(params Attr[] attrs)
        {
            StartTag("select");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(IEnumerable<Attr> attrs)
        {
            StartTag("select");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }
        
        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1)
        {
            StartTag("select");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1, Attr attr2)
        {
            StartTag("select");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("select");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("select");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("select");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write a select element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder select(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("select");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("select", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(
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
            StartTag("option");
            
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
                Attr(new Eighty.Attr("disabled"));
            }
            if (selected)
            {
                Attr(new Eighty.Attr("selected"));
            }
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(params Attr[] attrs)
        {
            StartTag("option");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(IEnumerable<Attr> attrs)
        {
            StartTag("option");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }
        
        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1)
        {
            StartTag("option");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1, Attr attr2)
        {
            StartTag("option");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("option");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("option");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("option");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write an option element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder option(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("option");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("option", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("legend");
            
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
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(params Attr[] attrs)
        {
            StartTag("legend");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(IEnumerable<Attr> attrs)
        {
            StartTag("legend");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }
        
        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1)
        {
            StartTag("legend");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1, Attr attr2)
        {
            StartTag("legend");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("legend");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("legend");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a legend element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder legend(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("legend");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("legend", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(
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
            StartTag("meter");
            
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
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(params Attr[] attrs)
        {
            StartTag("meter");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(IEnumerable<Attr> attrs)
        {
            StartTag("meter");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }
        
        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1)
        {
            StartTag("meter");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1, Attr attr2)
        {
            StartTag("meter");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("meter");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("meter");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write a meter element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder meter(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("meter");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("meter", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(
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
            StartTag("output");
            
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
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(params Attr[] attrs)
        {
            StartTag("output");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(IEnumerable<Attr> attrs)
        {
            StartTag("output");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }
        
        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1)
        {
            StartTag("output");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1, Attr attr2)
        {
            StartTag("output");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("output");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("output");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("output");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write an output element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder output(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("output");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("output", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(
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
            StartTag("progress");
            
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
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(params Attr[] attrs)
        {
            StartTag("progress");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(IEnumerable<Attr> attrs)
        {
            StartTag("progress");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }
        
        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1)
        {
            StartTag("progress");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1, Attr attr2)
        {
            StartTag("progress");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("progress");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("progress");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a progress element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder progress(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("progress");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("progress", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(
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
            StartTag("menu");
            
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
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(params Attr[] attrs)
        {
            StartTag("menu");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(IEnumerable<Attr> attrs)
        {
            StartTag("menu");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }
        
        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1)
        {
            StartTag("menu");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1, Attr attr2)
        {
            StartTag("menu");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("menu");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("menu");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menu element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menu(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("menu");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("menu", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(
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
            StartTag("menuitem");
            
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
                Attr(new Eighty.Attr("disabled"));
            }
            if (@default)
            {
                Attr(new Eighty.Attr("default"));
            }
            if (@checked)
            {
                Attr(new Eighty.Attr("checked"));
            }
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(params Attr[] attrs)
        {
            StartTag("menuitem");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(IEnumerable<Attr> attrs)
        {
            StartTag("menuitem");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }
        
        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1)
        {
            StartTag("menuitem");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1, Attr attr2)
        {
            StartTag("menuitem");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("menuitem");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("menuitem");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a menuitem element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder menuitem(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("menuitem");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("menuitem", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            bool open = false
        )
        {
            StartTag("dialog");
            
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
                Attr(new Eighty.Attr("open"));
            }
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(params Attr[] attrs)
        {
            StartTag("dialog");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(IEnumerable<Attr> attrs)
        {
            StartTag("dialog");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }
        
        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1)
        {
            StartTag("dialog");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1, Attr attr2)
        {
            StartTag("dialog");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("dialog");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("dialog");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a dialog element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder dialog(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("dialog");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("dialog", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            bool open = false
        )
        {
            StartTag("details");
            
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
                Attr(new Eighty.Attr("open"));
            }
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(params Attr[] attrs)
        {
            StartTag("details");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(IEnumerable<Attr> attrs)
        {
            StartTag("details");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }
        
        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1)
        {
            StartTag("details");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1, Attr attr2)
        {
            StartTag("details");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("details");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("details");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("details");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a details element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder details(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("details");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("details", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("summary");
            
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
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(params Attr[] attrs)
        {
            StartTag("summary");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(IEnumerable<Attr> attrs)
        {
            StartTag("summary");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }
        
        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1)
        {
            StartTag("summary");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1, Attr attr2)
        {
            StartTag("summary");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("summary");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("summary");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write a summary element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder summary(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("summary");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("summary", _writer);
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(
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
            StartTag("img");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(params Attr[] attrs)
        {
            StartTag("img");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(IEnumerable<Attr> attrs)
        {
            StartTag("img");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1)
        {
            StartTag("img");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1, Attr attr2)
        {
            StartTag("img");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("img");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("img");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("img");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an img element.
        /// </summary>
        public void img(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("img");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(
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
            StartTag("audio");
            
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
                Attr(new Eighty.Attr("autoplay"));
            }
            if (loop)
            {
                Attr(new Eighty.Attr("loop"));
            }
            if (muted)
            {
                Attr(new Eighty.Attr("muted"));
            }
            if (controls)
            {
                Attr(new Eighty.Attr("controls"));
            }
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(params Attr[] attrs)
        {
            StartTag("audio");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(IEnumerable<Attr> attrs)
        {
            StartTag("audio");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }
        
        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1)
        {
            StartTag("audio");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1, Attr attr2)
        {
            StartTag("audio");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("audio");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("audio");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write an audio element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder audio(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("audio");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("audio", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(
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
            StartTag("video");
            
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
                Attr(new Eighty.Attr("autoplay"));
            }
            if (loop)
            {
                Attr(new Eighty.Attr("loop"));
            }
            if (muted)
            {
                Attr(new Eighty.Attr("muted"));
            }
            if (controls)
            {
                Attr(new Eighty.Attr("controls"));
            }
            if (crossorigin != null)
            {
                Attr(new Eighty.Attr("crossorigin", crossorigin));
            }
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(params Attr[] attrs)
        {
            StartTag("video");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(IEnumerable<Attr> attrs)
        {
            StartTag("video");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }
        
        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1)
        {
            StartTag("video");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1, Attr attr2)
        {
            StartTag("video");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("video");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("video");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("video");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a video element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder video(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("video");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("video", _writer);
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(
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
            StartTag("track");
            
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
                Attr(new Eighty.Attr("default"));
            }
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(params Attr[] attrs)
        {
            StartTag("track");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(IEnumerable<Attr> attrs)
        {
            StartTag("track");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1)
        {
            StartTag("track");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1, Attr attr2)
        {
            StartTag("track");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("track");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("track");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("track");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a track element.
        /// </summary>
        public void track(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("track");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(
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
            StartTag("embed");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(params Attr[] attrs)
        {
            StartTag("embed");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(IEnumerable<Attr> attrs)
        {
            StartTag("embed");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1)
        {
            StartTag("embed");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1, Attr attr2)
        {
            StartTag("embed");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("embed");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("embed");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an embed element.
        /// </summary>
        public void embed(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("embed");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(
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
            StartTag("object");
            
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
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(params Attr[] attrs)
        {
            StartTag("object");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(IEnumerable<Attr> attrs)
        {
            StartTag("object");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }
        
        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1)
        {
            StartTag("object");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1, Attr attr2)
        {
            StartTag("object");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("object");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("object");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("object");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write an object element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder @object(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("object");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("object", _writer);
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(
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
            StartTag("param");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(params Attr[] attrs)
        {
            StartTag("param");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(IEnumerable<Attr> attrs)
        {
            StartTag("param");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1)
        {
            StartTag("param");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1, Attr attr2)
        {
            StartTag("param");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("param");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("param");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("param");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a param element.
        /// </summary>
        public void param(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("param");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null
        )
        {
            StartTag("picture");
            
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
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(params Attr[] attrs)
        {
            StartTag("picture");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(IEnumerable<Attr> attrs)
        {
            StartTag("picture");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }
        
        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1)
        {
            StartTag("picture");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1, Attr attr2)
        {
            StartTag("picture");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("picture");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("picture");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a picture element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder picture(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("picture");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("picture", _writer);
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(
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
            StartTag("source");
            
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
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(params Attr[] attrs)
        {
            StartTag("source");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(IEnumerable<Attr> attrs)
        {
            StartTag("source");
            Attrs(attrs);
            _writer.Write("/>");
        }
        
        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1)
        {
            StartTag("source");
            Attrs(attr1);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1, Attr attr2)
        {
            StartTag("source");
            Attrs(attr1, attr2);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("source");
            Attrs(attr1, attr2, attr3);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("source");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("source");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a source element.
        /// </summary>
        public void source(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("source");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write("/>");
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(
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
            StartTag("canvas");
            
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
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(params Attr[] attrs)
        {
            StartTag("canvas");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(IEnumerable<Attr> attrs)
        {
            StartTag("canvas");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }
        
        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1)
        {
            StartTag("canvas");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1, Attr attr2)
        {
            StartTag("canvas");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("canvas");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("canvas");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a canvas element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder canvas(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("canvas");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("canvas", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string dir = null
        )
        {
            StartTag("bdi");
            
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
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(params Attr[] attrs)
        {
            StartTag("bdi");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(IEnumerable<Attr> attrs)
        {
            StartTag("bdi");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }
        
        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1)
        {
            StartTag("bdi");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1, Attr attr2)
        {
            StartTag("bdi");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("bdi");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("bdi");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdi element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdi(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("bdi");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("bdi", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(
            string id = null,
            string @class = null,
            string style = null,
            string title = null,
            string tabindex = null,
            string contenteditable = null,
            string dir = null
        )
        {
            StartTag("bdo");
            
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
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(params Attr[] attrs)
        {
            StartTag("bdo");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(IEnumerable<Attr> attrs)
        {
            StartTag("bdo");
            Attrs(attrs);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }
        
        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1)
        {
            StartTag("bdo");
            Attrs(attr1);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1, Attr attr2)
        {
            StartTag("bdo");
            Attrs(attr1, attr2);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3)
        {
            StartTag("bdo");
            Attrs(attr1, attr2, attr3);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4)
        {
            StartTag("bdo");
            Attrs(attr1, attr2, attr3, attr4);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5)
        {
            StartTag("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6)
        {
            StartTag("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7)
        {
            StartTag("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }

        /// <summary>
        /// Write a bdo element. The returned value MUST be disposed exactly once, immediately after the children have been written.
        /// </summary>
        /// <returns>A <see cref="TagBuilder"/> which MUST be disposed exactly once, immediately after the children have been written</returns>
        public TagBuilder bdo(Attr attr1, Attr attr2, Attr attr3, Attr attr4, Attr attr5, Attr attr6, Attr attr7, Attr attr8)
        {
            StartTag("bdo");
            Attrs(attr1, attr2, attr3, attr4, attr5, attr6, attr7, attr8);
            _writer.Write('>');
            return new TagBuilder("bdo", _writer);
        }
    }
}
#endregion
