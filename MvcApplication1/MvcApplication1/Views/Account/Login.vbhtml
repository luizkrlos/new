﻿@ModelType MvcApplication1.LoginModel

@Code
    ViewData("Title") = " "
End Code

<hgroup class="title">
    <h1>@ViewData("Title").</h1>
</hgroup>

<section id="loginForm">

@Using Html.BeginForm(New With { .ReturnUrl = ViewData("ReturnUrl") })
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(true)

    @<fieldset class="contenedor_negro">
         <h2>Iniciar sesión (localhost).</h2>
        <legend>Formulario de inicio de sesión</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.UserName)
                @Html.TextBoxFor(Function(m) m.UserName)
                @Html.ValidationMessageFor(Function(m) m.UserName)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.Password)
                @Html.PasswordFor(Function(m) m.Password)
                @Html.ValidationMessageFor(Function(m) m.Password)
            </li>
            <li>
                @Html.CheckBoxFor(Function(m) m.RememberMe)
                @Html.LabelFor(Function(m) m.RememberMe, New With { .Class = "checkbox" })
            </li>
        </ol>
        <input type="submit" value="Iniciar sesión" />
    </fieldset>
    @<p>
        @Html.ActionLink("Regístrese", "Register") si no tiene ninguna cuenta.
    </p>
End Using
</section>

<section class="social contenedor_negro" id="socialLoginForm">
    <h2>Usar otro servicio para iniciar sesión.</h2>
    @Html.Action("ExternalLoginsList", New With {.ReturnUrl = ViewData("ReturnUrl")})
</section>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
