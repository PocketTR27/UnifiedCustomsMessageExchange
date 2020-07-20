* Put the PFX file of your certificate (with its private key)
  [for decryption of incoming requests] here and reference it in Web.config
  - Do not forget to add the password of your PFX file in Web.config
    (if there is a password)
* Put the CER (in PEM or DER format) file of IRU certificate
  [for encryption of answers] here and reference it in Web.config