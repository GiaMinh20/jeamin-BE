(self.webpackChunk_N_E=self.webpackChunk_N_E||[]).push([[643],{35472:function(a,b,c){(window.__NEXT_P=window.__NEXT_P||[]).push(["/user/notification",function(){return c(91932)}])},34165:function(a,b,c){"use strict";var d=c(28520),e=c.n(d),f=c(85893),g=c(30381),h=c.n(g),i=c(67294),j=c(50739);function k(a,b,c,d,e,f,g){try{var h=a[f](g),i=h.value}catch(j){c(j);return}h.done?b(i):Promise.resolve(i).then(d,e)}b.Z=function(a){var b=a.handleFilter,c=a.isFetching,d=(0,i.useRef)(null),g=(0,i.useRef)(null);function l(){return m.apply(this,arguments)}function m(){return(m=(function(a){return function(){var b=this,c=arguments;return new Promise(function(d,e){var f=a.apply(b,c);function g(a){k(f,d,e,g,h,"next",a)}function h(a){k(f,d,e,g,h,"throw",a)}g(void 0)})}})(e().mark(function a(c){var f,i;return e().wrap(function(a){for(;;)switch(a.prev=a.next){case 0:if(f=void 0!==c&&c,b){a.next=3;break}return a.abrupt("return");case 3:if(f){a.next=6;break}return b({FromDate:d.current,ToDate:g.current}),a.abrupt("return");case 6:b({FromDate:i=h()().format("YYYY-MM-DD"),ToDate:i});case 8:case"end":return a.stop()}},a)}))).apply(this,arguments)}return(0,f.jsxs)("div",{className:"xl:flex w-fit items-end",children:[(0,f.jsx)("div",{className:"mr-4 mb-4 xl:mb-0 w-[400px]",children:(0,f.jsx)(j.jwb,{disabled:c,format:"DD/MM/YYYY",placeholder:"Từ ng\xe0y / đến ng\xe0y",handleDate:function(a){d.current=a[0],g.current=a[1]}})}),(0,f.jsx)("div",{children:(0,f.jsx)(j.hU,{icon:"fas fa-search",title:"T\xecm?",onClick:l,showLoading:!0,toolip:"",disabled:c})}),(0,f.jsx)("div",{className:"ml-4",children:(0,f.jsx)(j.hU,{icon:"far fa-info-square",title:"Lọc h\xf4m nay",onClick:function(){l(!0)},showLoading:!0,toolip:"",disabled:c})})]})}},89679:function(a,b,c){"use strict";var d=c(85893),e=c(20550),f=c(28985),g=c(41664);c(67294);var h=c(48880),i=c(12741),j=c(83178),k=c(12954);function l(a,b,c){return b in a?Object.defineProperty(a,b,{value:c,enumerable:!0,configurable:!0,writable:!0}):a[b]=c,a}b.Z=function(a){var b=a.data,c=a.loading,m=a.handleFilter,n=a.filter;return(0,d.jsxs)(d.Fragment,{children:[(0,d.jsx)(j.w,{loading:c,columns:[{dataIndex:"Id",title:"STT",width:50,render:function(a,b,c){return++c}},{dataIndex:"NotificationContent",title:"Nội dung",responsive:["lg"],width:200},{dataIndex:"TotalPriceReceive",title:"Trạng th\xe1i",responsive:["xl"],width:120,render:function(a,b){return(0,d.jsx)(e.Z,{color:b.IsRead?"blue":"red",children:b.IsRead?"Đ\xe3 xem":"Chưa xem"})}},{dataIndex:"Created",title:"Ng\xe0y",width:130,render:function(a){return k.Jy.getVNDate(a)},responsive:["sm"]},{dataIndex:"GoToDetail",title:"Xem chi tiết",align:"center",width:90,render:function(a,b){return(0,d.jsx)(g.default,{href:null==b?void 0:b.Url,children:(0,d.jsx)("a",{style:{opacity:b.Url?"1":"0.3",pointerEvents:b.Url?"all":"none",cursor:b.Url?"pointer":"none"},target:"_blank",children:(0,d.jsx)(i.K,{icon:"far fa-info-square",title:"Xem chi tiết",onClick:function(){b.IsRead||(b.IsRead=!0,h.Cu.readNotify([null==b?void 0:b.Id]))}})})})}},],data:b,bordered:!0,expandable:{expandedRowRender:function(a){return(0,d.jsxs)("ul",{className:"px-2 text-xs",children:[(0,d.jsxs)("li",{className:"sm:hidden justify-between flex py-2",children:[(0,d.jsx)("span",{className:"font-medium mr-4",children:"Ng\xe0y:"}),(0,d.jsx)("div",{children:k.Jy.getShortVNDate(null==a?void 0:a.Created)})]}),(0,d.jsxs)("li",{className:"md:hidden justify-between flex py-2",children:[(0,d.jsx)("span",{className:"font-medium mr-4",children:"Nội dung:"}),(0,d.jsx)("div",{children:null==a?void 0:a.NotificationContent})]}),(0,d.jsxs)("li",{className:"xl:hidden justify-between flex py-2",children:[(0,d.jsx)("span",{className:"font-medium mr-4",children:"Trạng th\xe1i:"}),(0,d.jsx)("div",{children:null==a?void 0:a.TotalPriceReceive})]})]})}},scroll:{y:700}}),(0,d.jsx)("div",{className:"mt-4 text-right",children:(0,d.jsx)(f.Z,{total:null==n?void 0:n.TotalItems,current:null==n?void 0:n.PageIndex,pageSize:null==n?void 0:n.PageSize,onChange:function(a,b){return m(function(a){for(var b=1;b<arguments.length;b++){var c=null!=arguments[b]?arguments[b]:{},d=Object.keys(c);"function"==typeof Object.getOwnPropertySymbols&&(d=d.concat(Object.getOwnPropertySymbols(c).filter(function(a){return Object.getOwnPropertyDescriptor(c,a).enumerable}))),d.forEach(function(b){l(a,b,c[b])})}return a}({},n,{PageIndex:a,PageSize:b}))}})})]})}},93702:function(a,b,c){"use strict";c.d(b,{B:function(){return d},W:function(){return e}});var d={dasboard:"Trang điều khiển",settings:{system:"Cấu h\xecnh hệ thống",feeTQVN:"Cấu h\xecnh vận chuyển TQVN",feeBuy:"Cấu h\xecnh ph\xed dịch vụ mua h\xe0ng",feePayFor:"Cấu h\xecnh ph\xed thanh to\xe1n hộ",feeUser:"Cấu h\xecnh ph\xed người d\xf9ng",listBank:"Danh s\xe1ch ng\xe2n h\xe0ng",notification:"Cấu h\xecnh th\xf4ng b\xe1o",goodsChecking:"Cấu h\xecnh ph\xed kiểm đếm",wareHouse:"Cấu h\xecnh kho TQ - VN",volume:"Cấu h\xecnh ph\xed thể t\xedch"},staff:{employeeManager:"Quản l\xfd nh\xe2n vi\xean",decentralization:"Quản l\xfd ph\xe2n quyền",infoAccount:"Th\xf4ng tin t\xe0i khoản",commissionManager:"Quản l\xfd hoa hồng",adminManagement:"Quản l\xfd admin"},listCustomer:"Danh s\xe1ch kh\xe1ch h\xe0ng",createNewClient:"Th\xeam mới kh\xe1ch h\xe0ng",oder:{orderMain:"Danh s\xe1ch đơn h\xe0ng",oderBuyFor:"Đơn h\xe0ng mua hộ",oderBuyForOther:"Đơn h\xe0ng mua hộ kh\xe1c",payFor:"Đơn h\xe0ng thanh to\xe1n hộ",detail:" Chi tiết đơn h\xe0ng",payOder:"Thanh to\xe1n đơn h\xe0ng",createdOder:"Tạo đơn h\xe0ng kh\xe1c",detailProduct:"Chi tiết sản phẩm"},handleComplaint:"Xử l\xfd khiếu nại",deposit:{listDeposit:"Danh s\xe1ch k\xfd gửi",statisticalFeeDeposit:"Thống k\xea cước k\xfd gửi",exportDepositRequest:"Xuất kho k\xfd gửi đ\xe3 y\xeau cầu",exportDeposit:"Xuất kho kiện chưa y\xeau cầu",detailRequest:"Chi tiết y\xeau cầu"},checkWarehouseTQ:"Kiểm h\xe0ng kho TQ",checkWarehouseVN:"Kiểm h\xe0ng kho VN",importWarehouseTQ:"Nhập kho TQ",assignPro:"G\xe1n kiện cho kh\xe1ch",export:"Xuất kho",parcelManagement:{packageManagement:"Quản l\xfd bao h\xe0ng",billCodeManager:"Quản l\xfd m\xe3 vận đơn",lostCase:"Danh s\xe1ch kiện thất lạc",floatingCase:"Danh s\xe1ch kiện tr\xf4i nổi",detailPackageManagement:"Quản l\xfd bao h\xe0ng chi tiết"},moneyManagement:{personalRecharge:"quản l\xfd nạp tiền c\xe1 nh\xe2n",historyRechargeVN:"Lịch sử nạp tiền",historyWithdrawVN:"Lịch sử r\xfat tiền",historyRechargeTQ:"Lịch sử nạp tệ",historyWithdrawTQ:"Lịch sử r\xfat tệ",historyTransaction:"Lịch sử giao dịch",payExport:"Thanh to\xe1n xuất kho",detailPayExport:"Chi tiết thanh to\xe1n xuất kho"},statistical:{printPurchaseVoucher:"In phiếu mua hộ",turnover:"Thống k\xea doanh thu",depositMoney:"Thống k\xea tiền nạp",surplus:"Thống k\xea số dư",transaction:"Thống k\xea giao dịch",other:"Thống k\xea đơn h\xe0ng",realMoney:"Thống k\xea tiền mua h\xe0ng",depositRevenue:"Thống k\xea k\xfd gửi",salesRevenue:"Thống k\xea sale",orderRevenue:"Thống k\xea đặt h\xe0ng",profitBuyFor:"Thống k\xea lợi nhuận mua hộ",profitPayFor:"Thống k\xea lợi nhuận mua hộ"},post:{Categories:"Chuy\xean mục b\xe0i viết",listPost:"B\xe0i viết",addCategories:" Th\xeam chuy\xean mục",editCategories:"Chỉnh sửa chuy\xean mục",addPost:"Th\xeam b\xe0i viết",editPost:"Chỉnh sửa b\xe0i viết"},homepageContent:"Cấu h\xecnh trang chủ",detailMenu:"Chi tiết Menu",addMenuChild:"Th\xeam menu con",addMenu:"Th\xeam menu",signIn:"Đăng nhập",register:"Đăng k\xfd",forgotPassword:"Kh\xf4i phục mật khẩu",homePage:"MONAMEDIA NHTQ",notification:"Th\xf4ng b\xe1o"},e={dashboard:"Dashboard",shopping:{shopingBag:"Giỏ h\xe0ng",payment:"Thanh to\xe1n"},buyGroceries:{listOder:"Danh s\xe1ch đơn h\xe0ng",createOderPageTMDT:"Tạo đơn h\xe0ng trang TMĐT Kh\xe1c",listOderTMĐT:"Danh s\xe1ch đơn h\xe0ng"},consignmentShipping:{createOderDeposit:"Tạo đơn h\xe0ng k\xfd gửi",listOderDeposit:"Danh s\xe1ch đơn h\xe0ng k\xfd gửi",statisticalDeposit:"Thống k\xea cước k\xfd gửi"},payFor:{listRequest:"Danh s\xe1ch y\xeau cầu thanh to\xe1n hộ",createRequest:"Tạo y\xeau cầu thanh to\xe1n hộ",detaiPay:"Chi tiết thanh to\xe1n hộ"},financialManagement:{listTransactionVND:" Danh s\xe1ch giao dịch VNĐ",listTransactionTQ:" Danh s\xe1ch giao dịch VNĐ",rechargeVNĐ:"Nạp tiền VNĐ",rechargeTQ:"Nạp tiền TQ",withdrawMoneyVND:"R\xfat tiền VNĐ",withdrawMoneyTQ:"R\xfat tiền TQ"},complain:"Khiếu nại",floating:"Kiện tr\xf4i nổi",createComplain:"Tạo khiếu nại mới",tracking:"Theo d\xf5i vận chuyển",infoUser:"Th\xf4ng tin người d\xf9ng"}},91932:function(a,b,c){"use strict";c.r(b);var d=c(85893),e=c(67294),f=c(88767),g=c(48880),h=c(50739),i=c(34165),j=c(89679),k=c(12023),l=c(93702),m=c(13431);function n(a,b,c){return b in a?Object.defineProperty(a,b,{value:c,enumerable:!0,configurable:!0,writable:!0}):a[b]=c,a}function o(a){for(var b=1;b<arguments.length;b++){var c=null!=arguments[b]?arguments[b]:{},d=Object.keys(c);"function"==typeof Object.getOwnPropertySymbols&&(d=d.concat(Object.getOwnPropertySymbols(c).filter(function(a){return Object.getOwnPropertyDescriptor(c,a).enumerable}))),d.forEach(function(b){n(a,b,c[b])})}return a}var p=function(a){var b=a.connection,c=(0,m.CG)(function(a){return a.user.current}),k=(0,e.useState)({TotalItems:null,PageIndex:1,PageSize:20,FromDate:null,ToDate:null,OrderBy:"Id desc",UID:null==c?void 0:c.UserId,OfEmployee:!1,IsRead:0}),l=k[0],n=k[1],p=(0,f.useQuery)(["menuData",l],function(){return g.t6.getList(l).then(function(a){var b,c,d,e;return n(o({},l,{TotalItems:null==a?void 0:null===(b=a.Data)|| void 0===b?void 0:b.TotalItem,PageIndex:null==a?void 0:null===(c=a.Data)|| void 0===c?void 0:c.PageIndex,PageSize:null==a?void 0:null===(d=a.Data)|| void 0===d?void 0:d.PageSize})),(null==r?void 0:null===(e=r.Items)|| void 0===e?void 0:e.length)<=0&&h.Amu.info("Kh\xf4ng c\xf3 th\xf4ng b\xe1o trong khoảng thời gian n\xe0y!"),null==a?void 0:a.Data})},{retry:!1,enabled:!!c,onError:h.Amu.error}),q=p.isFetching,r=p.data;(0,e.useEffect)(function(){b&&b.on("send-notification",function(a){return null==r?void 0:r.Items.unshift(a)})},[b]);var s=function(a){n(o({},l,a))};return(0,d.jsxs)(d.Fragment,{children:[(0,d.jsx)("div",{className:"titlePageUser",children:"Danh s\xe1ch th\xf4ng b\xe1o"}),(0,d.jsxs)("div",{className:"tableBox",children:[(0,d.jsx)("div",{children:(0,d.jsx)(i.Z,{handleFilter:s,isFetching:q})}),(0,d.jsx)("div",{className:"mt-4",children:(0,d.jsx)(j.Z,{data:null==r?void 0:r.Items,loading:q,filter:l,handleFilter:s})})]})]})};p.displayName=l.B.notification,p.breadcrumb=k.m.notification,p.Layout=h.rfd,b.default=p}},function(a){a.O(0,[675,296,3662,7570,9972,972,9774,2888,179],function(){return a(a.s=35472)}),_N_E=a.O()}])