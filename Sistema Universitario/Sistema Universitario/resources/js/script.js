$(document).on('ready',function(){
   $('.menu__toggle').on('click',function(){
       $(this).next().toggleClass('menu__lista--oculta');
    });

   $('.menu__link--intranet').on('click',function(){
       $('.formulario__caja').val('');
   		$('.formulario').addClass('formulario--mostrar');

   });
    $('.menu__link').on('click',function(){
        $('.menu__lista').addClass('menu__lista--oculta');
    });
   $('.formulario__invisible').on('click',function(){
        $('.formulario').removeClass('formulario--mostrar');
   });

    //menu intranet
    var menutoogle=$('#headernet').find('.menu__toggle');
    menutoogle.on('click',function(){
        $('body').toggleClass('open__body');
        $('.menu__headernet').toggleClass('menu__headernet--abierto');

    });
    $('.menu__icono-cerrar').on('click',function(){
        $(this).parent().removeClass('menu__headernet--abierto');
        $('body').removeClass('open__body');
    });

        $('#formulario').submit(function(e) {
            e.preventDefault();
        }).validate({
            debug: false,
            messages: {
                "inputUsuario": {
                    required: "Introduce tu Usuario."
                    number: "Introduce un código postal válido.",
                    maxlength: "Debe contener 10 digitos.",
                    minlength: "Debe contener 10 dígitos."
                },
                
                "inputPass": {
                    required: "Introduce tu contraseña.",
                    number: "Introduce un código postal válido.",
                    maxlength: "Debe contener 10 dígitos.",
                    minlength: "Debe contener 10 dígitos."
                }
            }
 
        });



});