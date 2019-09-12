using System;
using JetBrains.Annotations;

#pragma warning disable 1591

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class ElementStylePropertyName
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="propertyName">...Description to be added...</param>
        public ElementStylePropertyName([NotNull] string propertyName)
        {
            PropertyName = propertyName ?? throw new ArgumentNullException(nameof(propertyName));
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string PropertyName { get; }

        public static ElementStylePropertyName Aligncontent => new ElementStylePropertyName("align-content");
        public static ElementStylePropertyName Alignitems => new ElementStylePropertyName("align-items");
        public static ElementStylePropertyName Alignself => new ElementStylePropertyName("align-self");
        public static ElementStylePropertyName All => new ElementStylePropertyName("all");
        public static ElementStylePropertyName Animation => new ElementStylePropertyName("animation");
        public static ElementStylePropertyName Animationdelay => new ElementStylePropertyName("animation-delay");

        public static ElementStylePropertyName Animationdirection =>
            new ElementStylePropertyName("animation-direction");

        public static ElementStylePropertyName Animationduration => new ElementStylePropertyName("animation-duration");

        public static ElementStylePropertyName Animationfillmode =>
            new ElementStylePropertyName("animation-fill-mode");

        public static ElementStylePropertyName Animationiterationcount =>
            new ElementStylePropertyName("animation-iteration-count");

        public static ElementStylePropertyName Animationname => new ElementStylePropertyName("animation-name");

        public static ElementStylePropertyName Animationplaystate =>
            new ElementStylePropertyName("animation-play-state");

        public static ElementStylePropertyName Animationtimingfunction =>
            new ElementStylePropertyName("animation-timing-function");

        public static ElementStylePropertyName Backfacevisibility =>
            new ElementStylePropertyName("backface-visibility");

        public static ElementStylePropertyName Background => new ElementStylePropertyName("background");

        public static ElementStylePropertyName Backgroundattachment =>
            new ElementStylePropertyName("background-attachment");

        public static ElementStylePropertyName Backgroundblendmode =>
            new ElementStylePropertyName("background-blend-mode");

        public static ElementStylePropertyName Backgroundclip => new ElementStylePropertyName("background-clip");
        public static ElementStylePropertyName BackgroundColor => new ElementStylePropertyName("background-color");
        public static ElementStylePropertyName Backgroundimage => new ElementStylePropertyName("background-image");
        public static ElementStylePropertyName Backgroundorigin => new ElementStylePropertyName("background-origin");

        public static ElementStylePropertyName Backgroundposition =>
            new ElementStylePropertyName("background-position");

        public static ElementStylePropertyName Backgroundrepeat => new ElementStylePropertyName("background-repeat");
        public static ElementStylePropertyName Backgroundsize => new ElementStylePropertyName("background-size");
        public static ElementStylePropertyName Blocksize => new ElementStylePropertyName("block-size");
        public static ElementStylePropertyName Border => new ElementStylePropertyName("border");
        public static ElementStylePropertyName Borderblock => new ElementStylePropertyName("border-block");
        public static ElementStylePropertyName Borderblockcolor => new ElementStylePropertyName("border-block-color");
        public static ElementStylePropertyName Borderblockend => new ElementStylePropertyName("border-block-end");

        public static ElementStylePropertyName Borderblockendcolor =>
            new ElementStylePropertyName("border-block-end-color");

        public static ElementStylePropertyName Borderblockendstyle =>
            new ElementStylePropertyName("border-block-end-style");

        public static ElementStylePropertyName Borderblockendwidth =>
            new ElementStylePropertyName("border-block-end-width");

        public static ElementStylePropertyName Borderblockstart => new ElementStylePropertyName("border-block-start");

        public static ElementStylePropertyName Borderblockstartcolor =>
            new ElementStylePropertyName("border-block-start-color");

        public static ElementStylePropertyName Borderblockstartstyle =>
            new ElementStylePropertyName("border-block-start-style");

        public static ElementStylePropertyName Borderblockstartwidth =>
            new ElementStylePropertyName("border-block-start-width");

        public static ElementStylePropertyName Borderblockstyle => new ElementStylePropertyName("border-block-style");
        public static ElementStylePropertyName Borderblockwidth => new ElementStylePropertyName("border-block-width");
        public static ElementStylePropertyName BorderBottom => new ElementStylePropertyName("border-bottom");

        public static ElementStylePropertyName Borderbottomcolor =>
            new ElementStylePropertyName("border-bottom-color");

        public static ElementStylePropertyName Borderbottomleftradius =>
            new ElementStylePropertyName("border-bottom-left-radius");

        public static ElementStylePropertyName Borderbottomrightradius =>
            new ElementStylePropertyName("border-bottom-right-radius");

        public static ElementStylePropertyName Borderbottomstyle =>
            new ElementStylePropertyName("border-bottom-style");

        public static ElementStylePropertyName Borderbottomwidth =>
            new ElementStylePropertyName("border-bottom-width");

        public static ElementStylePropertyName Bordercollapse => new ElementStylePropertyName("border-collapse");
        public static ElementStylePropertyName Bordercolor => new ElementStylePropertyName("border-color");

        public static ElementStylePropertyName BorderendEndradius =>
            new ElementStylePropertyName("border-end-end-radius");

        public static ElementStylePropertyName Borderendstartradius =>
            new ElementStylePropertyName("border-end-start-radius");

        public static ElementStylePropertyName Borderimage => new ElementStylePropertyName("border-image");

        public static ElementStylePropertyName Borderimageoutset =>
            new ElementStylePropertyName("border-image-outset");

        public static ElementStylePropertyName Borderimagerepeat =>
            new ElementStylePropertyName("border-image-repeat");

        public static ElementStylePropertyName Borderimageslice => new ElementStylePropertyName("border-image-slice");

        public static ElementStylePropertyName Borderimagesource =>
            new ElementStylePropertyName("border-image-source");

        public static ElementStylePropertyName Borderimagewidth => new ElementStylePropertyName("border-image-width");
        public static ElementStylePropertyName Borderinline => new ElementStylePropertyName("border-inline");

        public static ElementStylePropertyName Borderinlinecolor =>
            new ElementStylePropertyName("border-inline-color");

        public static ElementStylePropertyName Borderinlineend => new ElementStylePropertyName("border-inline-end");

        public static ElementStylePropertyName Borderinlineendcolor =>
            new ElementStylePropertyName("border-inline-end-color");

        public static ElementStylePropertyName Borderinlineendstyle =>
            new ElementStylePropertyName("border-inline-end-style");

        public static ElementStylePropertyName Borderinlineendwidth =>
            new ElementStylePropertyName("border-inline-end-width");

        public static ElementStylePropertyName Borderinlinestart =>
            new ElementStylePropertyName("border-inline-start");

        public static ElementStylePropertyName Borderinlinestartcolor =>
            new ElementStylePropertyName("border-inline-start-color");

        public static ElementStylePropertyName Borderinlinestartstyle =>
            new ElementStylePropertyName("border-inline-start-style");

        public static ElementStylePropertyName Borderinlinestartwidth =>
            new ElementStylePropertyName("border-inline-start-width");

        public static ElementStylePropertyName Borderinlinestyle =>
            new ElementStylePropertyName("border-inline-style");

        public static ElementStylePropertyName Borderinlinewidth =>
            new ElementStylePropertyName("border-inline-width");

        public static ElementStylePropertyName Borderleft => new ElementStylePropertyName("border-left");
        public static ElementStylePropertyName Borderleftcolor => new ElementStylePropertyName("border-left-color");
        public static ElementStylePropertyName Borderleftstyle => new ElementStylePropertyName("border-left-style");
        public static ElementStylePropertyName Borderleftwidth => new ElementStylePropertyName("border-left-width");
        public static ElementStylePropertyName BorderRadius => new ElementStylePropertyName("border-radius");
        public static ElementStylePropertyName Borderright => new ElementStylePropertyName("border-right");
        public static ElementStylePropertyName Borderrightcolor => new ElementStylePropertyName("border-right-color");
        public static ElementStylePropertyName Borderrightstyle => new ElementStylePropertyName("border-right-style");
        public static ElementStylePropertyName Borderrightwidth => new ElementStylePropertyName("border-right-width");
        public static ElementStylePropertyName Borderspacing => new ElementStylePropertyName("border-spacing");

        public static ElementStylePropertyName Borderstartendradius =>
            new ElementStylePropertyName("border-start-end-radius");

        public static ElementStylePropertyName Borderstartstartradius =>
            new ElementStylePropertyName("border-start-start-radius");

        public static ElementStylePropertyName BorderStyle => new ElementStylePropertyName("border-style");
        public static ElementStylePropertyName Bordertop => new ElementStylePropertyName("border-top");
        public static ElementStylePropertyName Bordertopcolor => new ElementStylePropertyName("border-top-color");

        public static ElementStylePropertyName Bordertopleftradius =>
            new ElementStylePropertyName("border-top-left-radius");

        public static ElementStylePropertyName Bordertoprightradius =>
            new ElementStylePropertyName("border-top-right-radius");

        public static ElementStylePropertyName Bordertopstyle => new ElementStylePropertyName("border-top-style");
        public static ElementStylePropertyName Bordertopwidth => new ElementStylePropertyName("border-top-width");
        public static ElementStylePropertyName BorderWidth => new ElementStylePropertyName("border-width");
        public static ElementStylePropertyName Bottom => new ElementStylePropertyName("bottom");

        public static ElementStylePropertyName Boxdecorationbreak =>
            new ElementStylePropertyName("box-decoration-break");

        public static ElementStylePropertyName Boxshadow => new ElementStylePropertyName("box-shadow");
        public static ElementStylePropertyName Boxsizing => new ElementStylePropertyName("box-sizing");
        public static ElementStylePropertyName Breakafter => new ElementStylePropertyName("break-after");
        public static ElementStylePropertyName Breakbefore => new ElementStylePropertyName("break-before");
        public static ElementStylePropertyName Breakinside => new ElementStylePropertyName("break-inside");
        public static ElementStylePropertyName Captionside => new ElementStylePropertyName("caption-side");
        public static ElementStylePropertyName Caretcolor => new ElementStylePropertyName("caret-color");
        public static ElementStylePropertyName Ch => new ElementStylePropertyName("ch");
        public static ElementStylePropertyName Clear => new ElementStylePropertyName("clear");
        public static ElementStylePropertyName Clip => new ElementStylePropertyName("clip");
        public static ElementStylePropertyName Clippath => new ElementStylePropertyName("clip-path");
        public static ElementStylePropertyName Cm => new ElementStylePropertyName("cm");
        public static ElementStylePropertyName Color => new ElementStylePropertyName("color");
        public static ElementStylePropertyName Coloradjust => new ElementStylePropertyName("color-adjust");
        public static ElementStylePropertyName Columncount => new ElementStylePropertyName("column-count");
        public static ElementStylePropertyName Columnfill => new ElementStylePropertyName("column-fill");
        public static ElementStylePropertyName Columngap => new ElementStylePropertyName("column-gap");
        public static ElementStylePropertyName Columnrule => new ElementStylePropertyName("column-rule");
        public static ElementStylePropertyName Columnrulecolor => new ElementStylePropertyName("column-rule-color");
        public static ElementStylePropertyName Columnrulestyle => new ElementStylePropertyName("column-rule-style");
        public static ElementStylePropertyName Columnrulewidth => new ElementStylePropertyName("column-rule-width");
        public static ElementStylePropertyName Columnspan => new ElementStylePropertyName("column-span");
        public static ElementStylePropertyName Columnwidth => new ElementStylePropertyName("column-width");
        public static ElementStylePropertyName Columns => new ElementStylePropertyName("columns");
        public static ElementStylePropertyName Content => new ElementStylePropertyName("content");
        public static ElementStylePropertyName Counterincrement => new ElementStylePropertyName("counter-increment");
        public static ElementStylePropertyName Counterreset => new ElementStylePropertyName("counter-reset");
        public static ElementStylePropertyName Counterset => new ElementStylePropertyName("counter-set");
        public static ElementStylePropertyName Cursor => new ElementStylePropertyName("cursor");
        public static ElementStylePropertyName Deg => new ElementStylePropertyName("deg");
        public static ElementStylePropertyName Direction => new ElementStylePropertyName("direction");
        public static ElementStylePropertyName Display => new ElementStylePropertyName("display");
        public static ElementStylePropertyName Dpcm => new ElementStylePropertyName("dpcm");
        public static ElementStylePropertyName Dpi => new ElementStylePropertyName("dpi");
        public static ElementStylePropertyName Dppx => new ElementStylePropertyName("dppx");
        public static ElementStylePropertyName Em => new ElementStylePropertyName("em");
        public static ElementStylePropertyName Emptycells => new ElementStylePropertyName("empty-cells");
        public static ElementStylePropertyName Ex => new ElementStylePropertyName("ex");
        public static ElementStylePropertyName Filter => new ElementStylePropertyName("filter");
        public static ElementStylePropertyName Flex => new ElementStylePropertyName("flex");
        public static ElementStylePropertyName Flexbasis => new ElementStylePropertyName("flex-basis");
        public static ElementStylePropertyName Flexdirection => new ElementStylePropertyName("flex-direction");
        public static ElementStylePropertyName Flexflow => new ElementStylePropertyName("flex-flow");
        public static ElementStylePropertyName Flexgrow => new ElementStylePropertyName("flex-grow");
        public static ElementStylePropertyName Flexshrink => new ElementStylePropertyName("flex-shrink");
        public static ElementStylePropertyName Flexwrap => new ElementStylePropertyName("flex-wrap");
        public static ElementStylePropertyName Float => new ElementStylePropertyName("float");
        public static ElementStylePropertyName Font => new ElementStylePropertyName("font");
        public static ElementStylePropertyName Fontfamily => new ElementStylePropertyName("font-family");

        public static ElementStylePropertyName Fontfeaturesettings =>
            new ElementStylePropertyName("font-feature-settings");

        public static ElementStylePropertyName Fontkerning => new ElementStylePropertyName("font-kerning");

        public static ElementStylePropertyName Fontlanguageoverride =>
            new ElementStylePropertyName("font-language-override");

        public static ElementStylePropertyName Fontopticalsizing =>
            new ElementStylePropertyName("font-optical-sizing");

        public static ElementStylePropertyName Fontsize => new ElementStylePropertyName("font-size");
        public static ElementStylePropertyName Fontsizeadjust => new ElementStylePropertyName("font-size-adjust");
        public static ElementStylePropertyName Fontstretch => new ElementStylePropertyName("font-stretch");
        public static ElementStylePropertyName Fontstyle => new ElementStylePropertyName("font-style");
        public static ElementStylePropertyName Fontsynthesis => new ElementStylePropertyName("font-synthesis");
        public static ElementStylePropertyName Fontvariant => new ElementStylePropertyName("font-variant");

        public static ElementStylePropertyName Fontvariantalternates =>
            new ElementStylePropertyName("font-variant-alternates");

        public static ElementStylePropertyName Fontvariantcaps => new ElementStylePropertyName("font-variant-caps");

        public static ElementStylePropertyName Fontvarianteastasian =>
            new ElementStylePropertyName("font-variant-east-asian");

        public static ElementStylePropertyName Fontvariantligatures =>
            new ElementStylePropertyName("font-variant-ligatures");

        public static ElementStylePropertyName Fontvariantnumeric =>
            new ElementStylePropertyName("font-variant-numeric");

        public static ElementStylePropertyName Fontvariantposition =>
            new ElementStylePropertyName("font-variant-position");

        public static ElementStylePropertyName Fontweight => new ElementStylePropertyName("font-weight");
        public static ElementStylePropertyName Fr => new ElementStylePropertyName("fr");
        public static ElementStylePropertyName Gap => new ElementStylePropertyName("gap");
        public static ElementStylePropertyName Grad => new ElementStylePropertyName("grad");
        public static ElementStylePropertyName Grid => new ElementStylePropertyName("grid");
        public static ElementStylePropertyName Gridarea => new ElementStylePropertyName("grid-area");
        public static ElementStylePropertyName Gridautocolumns => new ElementStylePropertyName("grid-auto-columns");
        public static ElementStylePropertyName Gridautoflow => new ElementStylePropertyName("grid-auto-flow");
        public static ElementStylePropertyName Gridautorows => new ElementStylePropertyName("grid-auto-rows");
        public static ElementStylePropertyName Gridcolumn => new ElementStylePropertyName("grid-column");
        public static ElementStylePropertyName Gridcolumnend => new ElementStylePropertyName("grid-column-end");
        public static ElementStylePropertyName Gridcolumnstart => new ElementStylePropertyName("grid-column-start");
        public static ElementStylePropertyName Gridrow => new ElementStylePropertyName("grid-row");
        public static ElementStylePropertyName Gridrowend => new ElementStylePropertyName("grid-row-end");
        public static ElementStylePropertyName Gridrowstart => new ElementStylePropertyName("grid-row-start");
        public static ElementStylePropertyName Gridtemplate => new ElementStylePropertyName("grid-template");

        public static ElementStylePropertyName Gridtemplateareas =>
            new ElementStylePropertyName("grid-template-areas");

        public static ElementStylePropertyName Gridtemplatecolumns =>
            new ElementStylePropertyName("grid-template-columns");

        public static ElementStylePropertyName Gridtemplaterows => new ElementStylePropertyName("grid-template-rows");
        public static ElementStylePropertyName Hz => new ElementStylePropertyName("Hz");

        public static ElementStylePropertyName Hangingpunctuation =>
            new ElementStylePropertyName("hanging-punctuation");

        public static ElementStylePropertyName Height => new ElementStylePropertyName("height");
        public static ElementStylePropertyName Hyphens => new ElementStylePropertyName("hyphens");
        public static ElementStylePropertyName Imageorientation => new ElementStylePropertyName("image-orientation");
        public static ElementStylePropertyName Imagerendering => new ElementStylePropertyName("image-rendering");
        public static ElementStylePropertyName In => new ElementStylePropertyName("in");
        public static ElementStylePropertyName Inherit => new ElementStylePropertyName("inherit");
        public static ElementStylePropertyName Initial => new ElementStylePropertyName("initial");
        public static ElementStylePropertyName Inlinesize => new ElementStylePropertyName("inline-size");
        public static ElementStylePropertyName Inset => new ElementStylePropertyName("inset");
        public static ElementStylePropertyName Insetblock => new ElementStylePropertyName("inset-block");
        public static ElementStylePropertyName Insetblockend => new ElementStylePropertyName("inset-block-end");
        public static ElementStylePropertyName Insetblockstart => new ElementStylePropertyName("inset-block-start");
        public static ElementStylePropertyName Insetinline => new ElementStylePropertyName("inset-inline");
        public static ElementStylePropertyName Insetinlineend => new ElementStylePropertyName("inset-inline-end");
        public static ElementStylePropertyName Insetinlinestart => new ElementStylePropertyName("inset-inline-start");
        public static ElementStylePropertyName Isolation => new ElementStylePropertyName("isolation");
        public static ElementStylePropertyName Justifycontent => new ElementStylePropertyName("justify-content");
        public static ElementStylePropertyName Justifyitems => new ElementStylePropertyName("justify-items");
        public static ElementStylePropertyName Justifyself => new ElementStylePropertyName("justify-self");
        public static ElementStylePropertyName KHz => new ElementStylePropertyName("kHz");
        public static ElementStylePropertyName Left => new ElementStylePropertyName("left");
        public static ElementStylePropertyName Letterspacing => new ElementStylePropertyName("letter-spacing");
        public static ElementStylePropertyName Linebreak => new ElementStylePropertyName("line-break");
        public static ElementStylePropertyName Lineheight => new ElementStylePropertyName("line-height");
        public static ElementStylePropertyName Liststyle => new ElementStylePropertyName("list-style");
        public static ElementStylePropertyName Liststyleimage => new ElementStylePropertyName("list-style-image");

        public static ElementStylePropertyName Liststyleposition =>
            new ElementStylePropertyName("list-style-position");

        public static ElementStylePropertyName Liststyletype => new ElementStylePropertyName("list-style-type");
        public static ElementStylePropertyName Margin => new ElementStylePropertyName("margin");
        public static ElementStylePropertyName Marginblock => new ElementStylePropertyName("margin-block");
        public static ElementStylePropertyName Marginblockend => new ElementStylePropertyName("margin-block-end");
        public static ElementStylePropertyName Marginblockstart => new ElementStylePropertyName("margin-block-start");
        public static ElementStylePropertyName Marginbottom => new ElementStylePropertyName("margin-bottom");
        public static ElementStylePropertyName Margininline => new ElementStylePropertyName("margin-inline");
        public static ElementStylePropertyName Margininlineend => new ElementStylePropertyName("margin-inline-end");

        public static ElementStylePropertyName Margininlinestart =>
            new ElementStylePropertyName("margin-inline-start");

        public static ElementStylePropertyName Marginleft => new ElementStylePropertyName("margin-left");
        public static ElementStylePropertyName Marginright => new ElementStylePropertyName("margin-right");
        public static ElementStylePropertyName Margintop => new ElementStylePropertyName("margin-top");
        public static ElementStylePropertyName Mask => new ElementStylePropertyName("mask");
        public static ElementStylePropertyName Maskclip => new ElementStylePropertyName("mask-clip");
        public static ElementStylePropertyName Maskcomposite => new ElementStylePropertyName("mask-composite");
        public static ElementStylePropertyName Maskimage => new ElementStylePropertyName("mask-image");
        public static ElementStylePropertyName Maskmode => new ElementStylePropertyName("mask-mode");
        public static ElementStylePropertyName Maskorigin => new ElementStylePropertyName("mask-origin");
        public static ElementStylePropertyName Maskposition => new ElementStylePropertyName("mask-position");
        public static ElementStylePropertyName Maskrepeat => new ElementStylePropertyName("mask-repeat");
        public static ElementStylePropertyName Masksize => new ElementStylePropertyName("mask-size");
        public static ElementStylePropertyName Masktype => new ElementStylePropertyName("mask-type");
        public static ElementStylePropertyName Maxheight => new ElementStylePropertyName("max-height");
        public static ElementStylePropertyName Maxwidth => new ElementStylePropertyName("max-width");
        public static ElementStylePropertyName Minblocksize => new ElementStylePropertyName("min-block-size");
        public static ElementStylePropertyName Minheight => new ElementStylePropertyName("min-height");
        public static ElementStylePropertyName Mininlinesize => new ElementStylePropertyName("min-inline-size");
        public static ElementStylePropertyName Minwidth => new ElementStylePropertyName("min-width");
        public static ElementStylePropertyName Mixblendmode => new ElementStylePropertyName("mix-blend-mode");
        public static ElementStylePropertyName Mm => new ElementStylePropertyName("mm");
        public static ElementStylePropertyName Ms => new ElementStylePropertyName("ms");
        public static ElementStylePropertyName Objectfit => new ElementStylePropertyName("object-fit");
        public static ElementStylePropertyName Objectposition => new ElementStylePropertyName("object-position");
        public static ElementStylePropertyName Opacity => new ElementStylePropertyName("opacity");
        public static ElementStylePropertyName Order => new ElementStylePropertyName("order");
        public static ElementStylePropertyName Orphans => new ElementStylePropertyName("orphans");
        public static ElementStylePropertyName Outline => new ElementStylePropertyName("outline");
        public static ElementStylePropertyName Outlinecolor => new ElementStylePropertyName("outline-color");
        public static ElementStylePropertyName Outlineoffset => new ElementStylePropertyName("outline-offset");
        public static ElementStylePropertyName Outlinestyle => new ElementStylePropertyName("outline-style");
        public static ElementStylePropertyName Outlinewidth => new ElementStylePropertyName("outline-width");
        public static ElementStylePropertyName Overflow => new ElementStylePropertyName("overflow");
        public static ElementStylePropertyName Overflowwrap => new ElementStylePropertyName("overflow-wrap");
        public static ElementStylePropertyName Overflowx => new ElementStylePropertyName("overflow-x");
        public static ElementStylePropertyName Overflowy => new ElementStylePropertyName("overflow-y");
        public static ElementStylePropertyName Padding => new ElementStylePropertyName("padding");
        public static ElementStylePropertyName Paddingblock => new ElementStylePropertyName("padding-block");
        public static ElementStylePropertyName Paddingblockend => new ElementStylePropertyName("padding-block-end");

        public static ElementStylePropertyName Paddingblockstart =>
            new ElementStylePropertyName("padding-block-start");

        public static ElementStylePropertyName Paddingbottom => new ElementStylePropertyName("padding-bottom");
        public static ElementStylePropertyName Paddinginline => new ElementStylePropertyName("padding-inline");
        public static ElementStylePropertyName Paddinginlineend => new ElementStylePropertyName("padding-inline-end");

        public static ElementStylePropertyName Paddinginlinestart =>
            new ElementStylePropertyName("padding-inline-start");

        public static ElementStylePropertyName Paddingleft => new ElementStylePropertyName("padding-left");
        public static ElementStylePropertyName Paddingright => new ElementStylePropertyName("padding-right");
        public static ElementStylePropertyName Paddingtop => new ElementStylePropertyName("padding-top");
        public static ElementStylePropertyName Pagebreakafter => new ElementStylePropertyName("page-break-after");
        public static ElementStylePropertyName Pagebreakbefore => new ElementStylePropertyName("page-break-before");
        public static ElementStylePropertyName Pagebreakinside => new ElementStylePropertyName("page-break-inside");
        public static ElementStylePropertyName Pc => new ElementStylePropertyName("pc");
        public static ElementStylePropertyName Perspective => new ElementStylePropertyName("perspective");
        public static ElementStylePropertyName Perspectiveorigin => new ElementStylePropertyName("perspective-origin");
        public static ElementStylePropertyName Placecontent => new ElementStylePropertyName("place-content");
        public static ElementStylePropertyName Placeitems => new ElementStylePropertyName("place-items");
        public static ElementStylePropertyName Placeself => new ElementStylePropertyName("place-self");
        public static ElementStylePropertyName Pointerevents => new ElementStylePropertyName("pointer-events");
        public static ElementStylePropertyName Position => new ElementStylePropertyName("position");
        public static ElementStylePropertyName Pt => new ElementStylePropertyName("pt");
        public static ElementStylePropertyName Px => new ElementStylePropertyName("px");
        public static ElementStylePropertyName Q => new ElementStylePropertyName("Q");
        public static ElementStylePropertyName Quotes => new ElementStylePropertyName("quotes");
        public static ElementStylePropertyName Rad => new ElementStylePropertyName("rad");
        public static ElementStylePropertyName Rem => new ElementStylePropertyName("rem");
        public static ElementStylePropertyName Resize => new ElementStylePropertyName("resize");
        public static ElementStylePropertyName Revert => new ElementStylePropertyName("revert");
        public static ElementStylePropertyName Right => new ElementStylePropertyName("right");
        public static ElementStylePropertyName Rotate => new ElementStylePropertyName("rotate");
        public static ElementStylePropertyName Rowgap => new ElementStylePropertyName("row-gap");
        public static ElementStylePropertyName S => new ElementStylePropertyName("s");
        public static ElementStylePropertyName Scale => new ElementStylePropertyName("scale");
        public static ElementStylePropertyName Scrollbehavior => new ElementStylePropertyName("scroll-behavior");
        public static ElementStylePropertyName ScrollMargin => new ElementStylePropertyName("scroll-margin");

        public static ElementStylePropertyName ScrollMarginblock =>
            new ElementStylePropertyName("scroll-margin-block");

        public static ElementStylePropertyName ScrollMarginblockend =>
            new ElementStylePropertyName("scroll-margin-block-end");

        public static ElementStylePropertyName ScrollMarginblockstart =>
            new ElementStylePropertyName("scroll-margin-block-start");

        public static ElementStylePropertyName ScrollMarginbottom =>
            new ElementStylePropertyName("scroll-margin-bottom");

        public static ElementStylePropertyName ScrollMargininline =>
            new ElementStylePropertyName("scroll-margin-inline");

        public static ElementStylePropertyName ScrollMargininlineend =>
            new ElementStylePropertyName("scroll-margin-inline-end");

        public static ElementStylePropertyName ScrollMargininlinestart =>
            new ElementStylePropertyName("scroll-margin-inline-start");

        public static ElementStylePropertyName ScrollMarginleft => new ElementStylePropertyName("scroll-margin-left");

        public static ElementStylePropertyName ScrollMarginright =>
            new ElementStylePropertyName("scroll-margin-right");

        public static ElementStylePropertyName ScrollMargintop => new ElementStylePropertyName("scroll-margin-top");
        public static ElementStylePropertyName ScrollPadding => new ElementStylePropertyName("scroll-padding");

        public static ElementStylePropertyName ScrollPaddingblock =>
            new ElementStylePropertyName("scroll-padding-block");

        public static ElementStylePropertyName ScrollPaddingblockend =>
            new ElementStylePropertyName("scroll-padding-block-end");

        public static ElementStylePropertyName ScrollPaddingblockstart =>
            new ElementStylePropertyName("scroll-padding-block-start");

        public static ElementStylePropertyName ScrollPaddingbottom =>
            new ElementStylePropertyName("scroll-padding-bottom");

        public static ElementStylePropertyName ScrollPaddinginline =>
            new ElementStylePropertyName("scroll-padding-inline");

        public static ElementStylePropertyName ScrollPaddinginlineend =>
            new ElementStylePropertyName("scroll-padding-inline-end");

        public static ElementStylePropertyName ScrollPaddinginlinestart =>
            new ElementStylePropertyName("scroll-padding-inline-start");

        public static ElementStylePropertyName ScrollPaddingleft =>
            new ElementStylePropertyName("scroll-padding-left");

        public static ElementStylePropertyName ScrollPaddingright =>
            new ElementStylePropertyName("scroll-padding-right");

        public static ElementStylePropertyName ScrollPaddingtop => new ElementStylePropertyName("scroll-padding-top");
        public static ElementStylePropertyName Scrollsnapalign => new ElementStylePropertyName("scroll-snap-align");
        public static ElementStylePropertyName Scrollsnapstop => new ElementStylePropertyName("scroll-snap-stop");
        public static ElementStylePropertyName Scrollsnaptype => new ElementStylePropertyName("scroll-snap-type");
        public static ElementStylePropertyName Scrollbarcolor => new ElementStylePropertyName("scrollbar-color");
        public static ElementStylePropertyName Scrollbarwidth => new ElementStylePropertyName("scrollbar-width");

        public static ElementStylePropertyName Shapeimagethreshold =>
            new ElementStylePropertyName("shape-image-threshold");

        public static ElementStylePropertyName Shapemargin => new ElementStylePropertyName("shape-margin");
        public static ElementStylePropertyName Shapeoutside => new ElementStylePropertyName("shape-outside");
        public static ElementStylePropertyName Tabsize => new ElementStylePropertyName("tab-size");
        public static ElementStylePropertyName Tablelayout => new ElementStylePropertyName("table-layout");
        public static ElementStylePropertyName TextAlign => new ElementStylePropertyName("text-align");
        public static ElementStylePropertyName Textalignlast => new ElementStylePropertyName("text-align-last");

        public static ElementStylePropertyName Textcombineupright =>
            new ElementStylePropertyName("text-combine-upright");

        public static ElementStylePropertyName Textdecoration => new ElementStylePropertyName("text-decoration");

        public static ElementStylePropertyName Textdecorationcolor =>
            new ElementStylePropertyName("text-decoration-color");

        public static ElementStylePropertyName Textdecorationline =>
            new ElementStylePropertyName("text-decoration-line");

        public static ElementStylePropertyName Textdecorationstyle =>
            new ElementStylePropertyName("text-decoration-style");

        public static ElementStylePropertyName Textemphasis => new ElementStylePropertyName("text-emphasis");

        public static ElementStylePropertyName Textemphasiscolor =>
            new ElementStylePropertyName("text-emphasis-color");

        public static ElementStylePropertyName Textemphasisposition =>
            new ElementStylePropertyName("text-emphasis-position");

        public static ElementStylePropertyName Textemphasisstyle =>
            new ElementStylePropertyName("text-emphasis-style");

        public static ElementStylePropertyName Textindent => new ElementStylePropertyName("text-indent");
        public static ElementStylePropertyName Textjustify => new ElementStylePropertyName("text-justify");
        public static ElementStylePropertyName Textorientation => new ElementStylePropertyName("text-orientation");
        public static ElementStylePropertyName Textoverflow => new ElementStylePropertyName("text-overflow");
        public static ElementStylePropertyName Textrendering => new ElementStylePropertyName("text-rendering");
        public static ElementStylePropertyName Textshadow => new ElementStylePropertyName("text-shadow");
        public static ElementStylePropertyName Texttransform => new ElementStylePropertyName("text-transform");

        public static ElementStylePropertyName Textunderlineposition =>
            new ElementStylePropertyName("text-underline-position");

        public static ElementStylePropertyName Top => new ElementStylePropertyName("top");
        public static ElementStylePropertyName Touchaction => new ElementStylePropertyName("touch-action");
        public static ElementStylePropertyName Transform => new ElementStylePropertyName("transform");
        public static ElementStylePropertyName Transformbox => new ElementStylePropertyName("transform-box");
        public static ElementStylePropertyName Transformorigin => new ElementStylePropertyName("transform-origin");
        public static ElementStylePropertyName Transformstyle => new ElementStylePropertyName("transform-style");
        public static ElementStylePropertyName Transition => new ElementStylePropertyName("transition");
        public static ElementStylePropertyName Transitiondelay => new ElementStylePropertyName("transition-delay");

        public static ElementStylePropertyName Transitionduration =>
            new ElementStylePropertyName("transition-duration");

        public static ElementStylePropertyName Transitionproperty =>
            new ElementStylePropertyName("transition-property");

        public static ElementStylePropertyName Transitiontimingfunction =>
            new ElementStylePropertyName("transition-timing-function");

        public static ElementStylePropertyName Translate => new ElementStylePropertyName("translate");
        public static ElementStylePropertyName Turn => new ElementStylePropertyName("turn");
        public static ElementStylePropertyName Unicodebidi => new ElementStylePropertyName("unicode-bidi");
        public static ElementStylePropertyName Unset => new ElementStylePropertyName("unset");
        public static ElementStylePropertyName Verticalalign => new ElementStylePropertyName("vertical-align");
        public static ElementStylePropertyName Vh => new ElementStylePropertyName("vh");
        public static ElementStylePropertyName Visibility => new ElementStylePropertyName("visibility");
        public static ElementStylePropertyName Vmax => new ElementStylePropertyName("vmax");
        public static ElementStylePropertyName Vmin => new ElementStylePropertyName("vmin");
        public static ElementStylePropertyName Vw => new ElementStylePropertyName("vw");
        public static ElementStylePropertyName Whitespace => new ElementStylePropertyName("white-space");
        public static ElementStylePropertyName Widows => new ElementStylePropertyName("widows");
        public static ElementStylePropertyName Width => new ElementStylePropertyName("width");
        public static ElementStylePropertyName Willchange => new ElementStylePropertyName("will-change");
        public static ElementStylePropertyName Wordbreak => new ElementStylePropertyName("word-break");
        public static ElementStylePropertyName Wordspacing => new ElementStylePropertyName("word-spacing");
        public static ElementStylePropertyName Wordwrap => new ElementStylePropertyName("word-wrap");
        public static ElementStylePropertyName Writingmode => new ElementStylePropertyName("writing-mode");
        public static ElementStylePropertyName X => new ElementStylePropertyName("x");
        public static ElementStylePropertyName ZIndex => new ElementStylePropertyName("z-index");
    }
}