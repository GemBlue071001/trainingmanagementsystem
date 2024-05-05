export interface Email {
    id?:string
    subject: string;
    body: string;
    senderName?: string;
    senderEmail?: string;
    toList: EmailRecipient[];
    ccList: EmailRecipient[];
    bccList: EmailRecipient[];
}

export interface EmailRecipient {
    emailAddress: string;
}