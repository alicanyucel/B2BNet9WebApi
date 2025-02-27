﻿namespace B2B.Core.Entities.Concrete;

public class User:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public DateTime AddedAt { get; set; }
    public bool IsActive {  get; set; }
    public bool MailConfirm {  get; set; }
    public string MailConfirmValue {  get; set; }
    public DateTime MailConfirmDate { get; set; }

}
