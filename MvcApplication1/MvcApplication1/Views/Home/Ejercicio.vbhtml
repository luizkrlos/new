﻿@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
@Code
    ViewData("Title") = "Ejercicio"
End Code


@section featured
    <section class="featured">
        <div class="content-wrapper">
            <div class="float-left">
                <p class="site-title">@Html.ActionLink(" ", "Index", "Home")</p>
            </div>
            <hgroup class="title">
                <h1>@ViewData("Message")</h1>
            </hgroup>
            <div id="intro" class="centrado">
                <table>
                    <tr>
                        <th class="centrado"><h2>BIENVENIDO</h2>
                        <th>
                    </tr>
                    <tr>
                        <td>
                            <p>Aqui encontraras recetas, ejercicios y tips para poder vencer la obesidad y la desnutricion</p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h3>Registrese:</h3>
                            <ol class="round">
                                <li class="one">
                                    <h5>Acceso a beneficios</h5>
                                    Usted podra registrarse de manera gratuita para tener acceso a contenido exclusivo
                                </li>

                                <li class="two">
                                    <h5>Contacte a su especialista en Nutricion</h5>
                                    Usted podra estar en contacto con expertos en el area de nutricion. Podra programar
                                    su proxima cita asi como ver el tratamiento que le hayan asignado y llevar un control
                                    de este.
                                </li>

                                <li class="three">
                                    <h5>Escriba sus dudas</h5>
                                    Podra acceder a nuestro foro privado en el cual podra preguntar y responder cualquier
                                    tipo de dudas de otros miembros.
                                </li>
                            </ol>

                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </section>
End Section

