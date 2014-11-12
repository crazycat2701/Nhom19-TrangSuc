// JavaScript Document
function goback()
{
	document.location= '#';
}
function xacnhanxoa(str)
{
	var s = 'Bạn có chắc là muốn xoá ';
	s += str;
	s+= ' ?';
	var answer =confirm(s);
	return answer;
}
function xacnhanxoahet()
{
	var s = 'Bạn có chắc là muốn xoá hết sản phẩm trong giỏ hàng';;
	s+= ' ?';
	var answer =confirm(s);
	return answer;
}

function checktknc() {
    if (!isFinite(document.tknangcao.giatu.value) || !isFinite(document.tknangcao.den.value)) {
        document.getElementById("_giatu").innerHTML = "Giá sản phẩm phải là số!";
        return false;
    }
    if (document.tknangcao.giatu.value < 0 || document.tknangcao.den.value < 0)
    {
        document.getElementById("_giatu").innerHTML = "Giá sản phẩm ít nhất là 0";
        return false;
    }
    else {
        document.getElementById("_giatu").innerHTML = "";
    }
    return true;
}
function checkstt() {
    if (document.formsave.pass.value.length == 0) {
        document.getElementById('pass1').innerHTML = "Phải nhập mật khẩu.";
        return false;
    }
    else if (document.formsave.pass.value.length < 6) {
        document.getElementById("pass1").innerHTML = "Mật khẩu ít nhất 6 ký tự."
        return false;
    }
    else {
        document.getElementById("pass1").innerHTML = "";
    }
}


function check_nam_nhuan(nam) {
    if ((nam % 4 == 0) && (nam % 100 != 0)) return true;
    else return false;
}
function checktt() {
    //if (document.formsave.username.value.length == 0) {
    //    document.getElementById('hoten').innerHTML = "Phải nhập họ tên";
    //    return false;
    //}
    //else {
    //    document.getElementById("hoten").innerHTML = "";
    //}

    var ngay = document.formsave.ngay.value;
    var thang = document.formsave.thang.value;
    var nam = document.formsave.nam.value;

    if (thang == 2) {
        var flag = 0;
        if (check_nam_nhuan(nam)) flag = 29;
        else flag = 28;
        if (ngay > flag) {
            document.getElementById('ngaygiaohang').innerHTML = "Ngày giao hàng không hợp lệ!";
            return false;
        }
        else {
            document.getElementById('ngaygiaohang').innerHTML = "";

        }
    }
    else if (thang == 4 || thang == 6 || thang == 9 || thang == 11) {
        if (ngay > 30) {
            document.getElementById('ngaygiaohang').innerHTML = "Ngày giao hàng không hợp lệ!";
            return false;
        }
        else {
            document.getElementById('ngaygiaohang').innerHTML = "";

        }
    }

    if (document.formsave.sdt.value.length == 0) {
        document.getElementById('dt').innerHTML = "Phải nhập số điện thoại";
        return false;
    }
    else {
        document.getElementById("dt").innerHTML = "";
    }
    //if (document.formsave.email.value.length == 0) {
    //    document.getElementById('mail').innerHTML = "Phải nhập email";
    //    return false;
    //}
    //else {
    //    document.getElementById("mail").innerHTML = "";
    //}
    if (document.formsave.diachi.value.length == 0) {
        document.getElementById('dc').innerHTML = "Phải nhập địa chỉ giao hàng";
        return false;
    }
    else {
        document.getElementById("dc").innerHTML = "";
    }
   
    return alert("Đơn đặt hàng đã được gửi đi.Xin cám ơn quý khách!");
}

function show_ttkhac() {
    document.getElementById("tt").style.display = "block";

}
function hide_ttkhac() {
    document.getElementById("tt").style.display = "none";
}

function checkEmail() {
    var mail = document.formsave.email;
    var filter = /^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$/;
    if (!filter.test(mail.value)) {
        document.getElementById('mail').innerHTML = "Email chưa hợp lệ!";
        mail.focus;
        return false;
    }
    else {
        document.getElementById('mail').innerHTML = "";
    }
    return true;
}
function checksdt() {
    if (!isFinite(document.formsave.sdt.value)) {
        document.getElementById("dt").innerHTML = "Phải là số!";
        return false;
    }
    else {
        document.getElementById("dt").innerHTML = "";
    }
    return true;
}


		
                
       function check_date_month() 
		{
            var ngay = document.mainForm.ngay.value;
            var thang = document.mainForm.thang.value;
            var nam = document.mainForm.nam.value;
            
            if (thang == 2) 
			{
                var dm = 0;
                if (check_nam_nhuan(nam)) dm = 29;
                else dm = 28;
                if (ngay > dm) 
				{
                    document.getElementById('ngaysinh').innerHTML="Ngày sinh không hợp lệ!";
                    return false;
                } 
				else 
				{
					document.getElementById('ngaysinh').innerHTML="";
					return true;
				}
            } 
			else 
			if (thang== 4 || thang == 6 || thang== 9 || thang == 11) 
			{
                if (ngay > 30) {
                    document.getElementById('ngaysinh').innerHTML="Ngày sinh không hợp lệ!";
                    return false;
                } 
				else 
				{
					document.getElementById('ngaysinh').innerHTML="";
					return true;
				}
            }
			if (thang== 1 || thang == 3|| thang== 5 || thang == 7 || thang==8 || thang==10 || thang==12) 
			{
					document.getElementById('ngaysinh').innerHTML="";
					return true;
            }
            return true;
        }
		
		function Check()
		{
			if (Cau2()==false)
				return false;
			if (checkEmail()==false)
				return false;
			if (check_date_month()==false)
				return false;
				return true;
				
		}
function show_hide() {
        if(document.getElementById("full").style.display!='block') 
		{
			document.getElementById("wrapper").style.display="none";
            document.getElementById("full").style.display = "block";
        }
        else 
		{
			document.getElementById("wrapper").style.display="block";
            document.getElementById("full").style.display = 'none';
        }
        return false;
    }
function initOverLabels () 
{
  if (!document.getElementById) return;      
  var labels, id, field;
  labels = document.getElementsByTagName('label');
  for (var i = 0; i < labels.length; i++) 
  {
    if (labels[i].className == 'overlabel') 
	{
      id = labels[i].htmlFor || labels[i].getAttribute ('for');
      if (!id || !(field = document.getElementById(id))) 
	  {
        continue;
      } 
      if (field.value !== '') 
	  {
        hideLabel(field.getAttribute('id'), true);
      }
      field.onfocus = function () 
	  {
        hideLabel(this.getAttribute('id'), true);
      };
      field.onblur = function () 
	  {
        if (this.value === '') 
		{
          hideLabel(this.getAttribute('id'), false);
        }
      };
      labels[i].onclick = function () 
	  {
        var id, field;
        id = this.getAttribute('for');
        if (id && (field = document.getElementById(id))) 
		{
          field.focus();
        }
      };
    }
  }
};

function hideLabel (field_id, hide) 
{
  var field_for;
  var labels = document.getElementsByTagName('label');
  for (var i = 0; i < labels.length; i++) 
  {
    field_for = labels[i].htmlFor || labels[i]. getAttribute('for');
    if (field_for == field_id) 
	{
      labels[i].style.textIndent = (hide) ? '-1000px' : '0px';
      return true;
    }
  }
}
function addLoadEvent(func) 
{
  var oldonload = window.onload;
  if (typeof window.onload != 'function') 
  {
    window.onload = func;
  } 
  else 
  {
    window.onload = function() 
	{
      if (oldonload) 
	  {
        oldonload();
      }
      func();
    }
  }
}

addLoadEvent(function() 
{
  setTimeout(initOverLabels, 50);
});



function time()
{
var Thu=new Array("Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư","Thứ Năm", "Thứ Sáu", "Thứ Bảy");
var Thang=new Array("01","02","03","04","05","06","07","08","09","10","11","12");
var today=new Date();
var Year=today.getYear();
if ((navigator.appName == "Microsoft Internet Explorer") && (Year < 2000))
	Year="19" + Year;
if (navigator.appName == "Netscape")
	Year=1900 + Year;
document.write(Thu[today.getDay()] + " , Ngày " + today.getDate() + " Tháng " +Thang[today.getMonth()] + " Năm " + Year +" "+ '')
}
