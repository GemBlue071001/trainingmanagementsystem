import httpClient from "../httpClient/httpClient";
import { Token } from "../model/access-token/access-token";
import { Email } from "../model/email/email";
import { EmailResponse } from "../model/emailResponse";

import apiLinks from "../util/api-link";

const getListEmail = async (): Promise<Email[]> => {
    const response = await httpClient.get({
      url: `${apiLinks.email.get_email}`,
    });
    const { result } = response.data as EmailResponse;
    return result as Email[];
  };


  const sendEmail = async (email: Email): Promise<any> => {
    const response = await httpClient.post({
      url: `${apiLinks.email.send_email}`,
      
      data:email
    });
    const { result } = response.data as any;
    return result as any;
  };

  const getToken = async ( code: string): Promise<string> => {
    const response = await httpClient.get({
      url: `${apiLinks.auth.get_token}`,
      params:{code},
    });
    const { access_token } = response.data as Token;
    return access_token as string;
  };

  const emailService = {
    getListEmail,
    sendEmail,
    getToken
  };
  export default emailService;