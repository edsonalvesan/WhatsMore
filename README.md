# WhatsMore
This program enables you to send messages to multiple WhatsApp accounts using your computer. I created WhatsMore to replace a script that a friend was using to do the same because it had some problematic limitations. Unlike other social platforms, WhatsApp still doesn't have an API that lets you send messages to users. They do have a Chat API, but this API only starts a conversation in a browser and is a lot like the 'mailto' protocol for email. As a result, we are left seeking alternative approaches while we wait for WhatsApp to catch up. As for the usefulness of WhatsMore, it will depend on your needs. In the case of my friend, he uses it as part of his business to send reminders to his clients regarding a particular job performed since he found they respond sooner this way than over email.

![Program Screenshot](https://github.com/StevenJDH/WhatsMore/raw/master/whatsmore-ss.jpg "Screenshot")

Releases: [https://github.com/StevenJDH/WhatsMore/releases](https://github.com/StevenJDH/WhatsMore/releases)

Changelog: [https://github.com/StevenJDH/WhatsMore/wiki/Changelog](https://github.com/StevenJDH/WhatsMore/wiki/Changelog)

## Features
* Send customizable messages to multiple WhatsApp users at the same time.
* Numbers with sending issues and or that are canceled are tracked so you can retry them again or save them for later.
* Localized for English and Spanish while making it easy to support more languages.

## NSIS installer project
I've included the NSIS (Nullsoft Scriptable Install System) script that I wrote to create the installer for WhatsMore. The script was written with NSIS 3.03, which you can find here [http://nsis.sourceforge.net/Main_Page](http://nsis.sourceforge.net/Main_Page), and it may not work with earlier versions due to missing features in the scripting language. The WhatsMore installer supports installing the program for all users, the current user, or for both at the same time. Silent installs and uninstalls can also be performed, English and Spanish languages are supported, and a restriction of at least Windows 7 is imposed to meet requirements for the .Net Framework version used.

## API service and pricing
This program uses the WaboxApp API for sending messages and getting status information about the linked phone. To use WhatsMore, you'll need to create an API token by first opening a free account here [https://www.waboxapp.com](https://www.waboxapp.com) and following the setup process there to link your phone. You are automatically allowed to send 100 free messages each month. The API service takes a pay as you go approach for payment, so you will be charged based on the number of messages you send, and only if you go over those 100 free messages each month. Current prices can be found here [https://www.waboxapp.com/pricing](https://www.waboxapp.com/pricing) on the WaboxApp website.

## Do you have any questions?
Many commonly asked questions are answered in the FAQ:
[https://github.com/StevenJDH/WhatsMore/wiki/FAQ](https://github.com/StevenJDH/WhatsMore/wiki/FAQ)

## Need to contact me?
I can be reached here directly at [https://21.co/stevenjdh](https://21.co/stevenjdh "Contact Page")

## Want to show your support?

|Method       | Address                                                                                                    |
|------------:|:-----------------------------------------------------------------------------------------------------------|
|PayPal:      | [https://www.paypal.me/stevenjdh](https://www.paypal.me/stevenjdh "Steven's Paypal Page")                  |
|Bitcoin:     | 3GyeQvN6imXEHVcdwrZwKHLZNGdnXeDfw2                                                                         |
|Litecoin:    | MAJtR4ccdyUQtiiBpg9PwF2AZ6Xbk5ioLm                                                                         |
|Ethereum:    | 0xa62b53c1d49f9C481e20E5675fbffDab2Fcda82E                                                                 |
|Dash:        | Xw5bDL93fFNHe9FAGHV4hjoGfDpfwsqAAj                                                                         |
|Zcash:       | t1a2Kr3jFv8WksgPBcMZFwiYM8Hn5QCMAs5                                                                        |
|PIVX:        | DQq2qeny1TveZDcZFWwQVGdKchFGtzeieU                                                                         |
|Ripple:      | rLHzPsX6oXkzU2qL12kHCH8G8cnZv1rBJh<br />Destination Tag: 2357564055                                        |
|Monero:      | 4GdoN7NCTi8a5gZug7PrwZNKjvHFmKeV11L6pNJPgj5QNEHsN6eeX3D<br />&#8618;aAQFwZ1ufD4LYCZKArktt113W7QjWvQ7CWDXrwM8yCGgEdhV3Wt|


// Steven Jenkins De Haro ("StevenJDH" on GitHub)
