


using ChainOfResponsibilityPattern.Classes;

Handler handler = new AuthenticationHandler();
handler.SetHandler(new AuthorisationHandler()).SetHandler(new MiddlewareHandler());
handler.Handle();