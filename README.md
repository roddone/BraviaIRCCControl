[![Build Status](https://travis-ci.org/roddone/BraviaIRCCControl.svg?branch=master)](https://travis-ci.org/roddone/BraviaIRCCControl)
[![Donate](https://img.shields.io/badge/%24-donate-ff00ff.svg)](https://www.paypal.me/roddone)

# BraviaIRCCControl
Simple .Net wrapper to control Sony Bravia devices through IRCC

## Retribution
If you find this package useful, please make a gift on Paypal : [https://www.paypal.me/roddone](https://www.paypal.me/roddone)

## Contribution
Do pull requests to implement more features !

## Prerequisites
1) Go in your TV settings and enable IP Control : Network > Home Network Setup > IP Control > Simple IP Control.
2) Set Authentication to "Normal and Pre-shared Key"
3) Choose a Pre-shared key.

The Pre-Shared Key will be asked when connecting.

## HowTo

Instanciate a "BraviaIRCCControl.IRCCController", and simply use the "Send" method with an IRCCCode:

```csharp
	IRCCController control = new IRCCController(hostname /*, port = 80, pinCode = "Pre-Shared-Key"*/);
	await control.Send(IRCCCodes.VolumeUp);
	await control.Send(IRCCCodes.VolumeDown);
	await control.Send(IRCCCodes.HDMI1);
	//etc.
```


## Extensions

There are extensions that allows to use some commands in a more readable way, to use them juste include `using BraviaIRCCControl.Extensions;`
For example : 
```csharp 
	await control.VolumeUp();
	await control.VolumeDown();
	await control.Play();
	await control.Pause();
	//etc.
```

For the moment there is not a lot of extensions, but you can implement others via pull request.

