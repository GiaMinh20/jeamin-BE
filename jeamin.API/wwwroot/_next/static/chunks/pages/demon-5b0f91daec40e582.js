(self.webpackChunk_N_E=self.webpackChunk_N_E||[]).push([[7128],{74713:function(a,b,c){(window.__NEXT_P=window.__NEXT_P||[]).push(["/demon",function(){return c(70038)}])},70038:function(a,b,c){"use strict";c.r(b);var d=c(28520),e=c.n(d),f=c(85893),g=c(31955),h=c(11163),i=c(72132),j=c(48880),k=c(13431),l=c(12954);function m(a,b,c,d,e,f,g){try{var h=a[f](g),i=h.value}catch(j){c(j);return}h.done?b(i):Promise.resolve(i).then(d,e)}var n="border !rounded-none !outline-0 mx-2 p-2",o="border !border-[#929292] py-2 px-3 hover:bg-[#e5d3bb] transition-all",p=function(){var a=function(a){var b=i.Am.loading("Đang xử l\xfd ...");j.YR.loginDemon(a).then(function(a){g.Z.set("tokenNHTQ-demo",null==a?void 0:null===(d=a.Data)|| void 0===d?void 0:d.token);try{var d,e,f,m=JSON.parse(l.Jy.getJWTDecode(null==a?void 0:null===(e=a.Data)|| void 0===e?void 0:e.token)["http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata"]);localStorage.setItem("currentUser",JSON.stringify(m)),c((0,k.av)(m)),c((0,k.OD)(m.UserGroupId)),(0,j.o4)(null==a?void 0:null===(f=a.Data)|| void 0===f?void 0:f.token),i.Am.update(b,{render:"Đang d\xf4 n\xe8 \xf4ng gi\xe0, đừng gấp :)))",isLoading:!1,autoClose:3000,type:"success"}),h.default.push("/user")}catch(n){i.Am.update(b,{render:"Lỗi g\xec k\xeca \xf4ng gi\xe0 :)))",isLoading:!1,autoClose:3000,type:"error"})}}).catch(function(a){i.Am.update(b,{render:"Lỗi k\xeca, ẩu qu\xe1 ku :)))",isLoading:!1,autoClose:3000,type:"error"})})},b=function(b){var c,d;b.preventDefault();var e=document.querySelectorAll("[data-login]");if(e){var f=null===(c=e[0])|| void 0===c?void 0:c.value,g=null===(d=e[1])|| void 0===d?void 0:d.value;f&&g&&a({Key:f,ID:g})}},c=(0,k.TL)();function d(){return(d=(function(a){return function(){var b=this,c=arguments;return new Promise(function(d,e){var f=a.apply(b,c);function g(a){m(f,d,e,g,h,"next",a)}function h(a){m(f,d,e,g,h,"throw",a)}g(void 0)})}})(e().mark(function a(){var b,c;return e().wrap(function(a){for(;;)switch(a.prev=a.next){case 0:c=null===(b=document.getElementById("KEY"))|| void 0===b?void 0:b.value,j.YR.getKey({Key:c}).then(function(a){var b=a.Data,c=document.getElementById("dataList");for(var d in c.innerHTML="\n\t\t\t\t\t<div style=\"display: flex; font-weight: bold;text-transform: uppercase;\">\n\t\t\t\t\t\t<div style=\"width: 50px\">Id</div>\n\t\t\t\t\t\t<div style=\"width: 130px\">UserName</div>\n\t\t\t\t\t\t<div style=\"width: 130px\">UserGroupName</div>\n\t\t\t\t\t</div>",b){var e=document.createElement("div"),f="\n\t\t\t\t\t<div style=\"display: flex\">\n\t\t\t\t\t\t<div style=\"width: 50px\">".concat(b[d].Id,"</div>\n\t\t\t\t\t\t<div style=\"width: 250px\">").concat(b[d].UserName,"</div>\n\t\t\t\t\t\t<div style=\"width: 130px\">").concat(b[d].UserGroupName,"</div>\n\t\t\t\t\t</div>");e.innerHTML=f,c.insertAdjacentElement("beforeend",e)}}).catch(function(a){i.Am.error("Key is required!")});case 3:case"end":return a.stop()}},a)}))).apply(this,arguments)}return(0,f.jsxs)("form",{onSubmit:b,children:[(0,f.jsxs)("div",{style:{padding:"10px"},children:[(0,f.jsx)("input",{className:n,type:"text",name:"",id:"KEY","data-login":!0,placeholder:"key"}),(0,f.jsx)("button",{className:o,type:"button",onClick:function(){return d.apply(this,arguments)},children:"Get"}),(0,f.jsx)("input",{className:n,type:"text",name:"",id:"PASS","data-login":!0,placeholder:"ID"}),(0,f.jsx)("button",{className:o,type:"submit",onClick:b,children:"Login"})]}),(0,f.jsx)("div",{id:"dataList",style:{margin:"20px",height:"800px",overflowY:"auto"}})]})};p.displayName="Đường tắt",p.breadcrumb="",b.default=p}},function(a){a.O(0,[675,296,3662,7570,9972,972,9774,2888,179],function(){return a(a.s=74713)}),_N_E=a.O()}])