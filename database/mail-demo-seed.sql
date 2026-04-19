IF NOT EXISTS (SELECT 1 FROM pine_mail_accounts WHERE imap_host='demo')
BEGIN
    INSERT INTO pine_mail_accounts (account_id, user_id, ad, email, imap_host, imap_port, imap_ssl, imap_user, imap_pass_enc, smtp_host, smtp_port, smtp_ssl, smtp_user, smtp_pass_enc, imza_html, aktif)
    VALUES (NEWID(), NULL, 'Demo Pinebi', 'admin@pinebi.com', 'demo', 993, 1, 'demo', 'demo', 'demo', 587, 1, 'demo', 'demo',
            '<div style="color:#64748b; font-size:12px;"><b>Admin</b> - Pinebi ERP</div>', 1);
END;
SELECT account_id, ad, email, imap_host FROM pine_mail_accounts WHERE imap_host='demo';
