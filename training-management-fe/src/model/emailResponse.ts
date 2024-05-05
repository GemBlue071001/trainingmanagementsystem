import { Email } from "./email/email";

export interface EmailResponse {
    result?: Email[];
    statusCode?: number;
    isError?: boolean;
    message?: string;
  }