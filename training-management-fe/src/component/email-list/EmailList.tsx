import { cwd } from "process";
import { Email } from "../../model/email/email";
import "./index.css"
import { Avatar, List } from 'antd';
import EmailComponent from "./Email/EmailComponent";

interface Props {
  emails: Email[];
}


const EmailList: React.FC<Props> = ({ emails }) => {
  console.log(emails);

  return (
    // <List
    //   itemLayout="horizontal"
    //   dataSource={emails}
    //   renderItem={(email, index) => (
    //     <List.Item >
    //       <List.Item.Meta
    //         avatar={<Avatar src={`https://xsgames.co/randomusers/avatar.php?g=pixel&key=${index}`} />}
    //         title={<span style={{ display: 'flex', justifyContent: 'flex-start' }}  >{email.subject}</span>}
    //         description={<span style={{ display: 'flex', justifyContent: 'flex-start' }}  >{email.body}</span>}

    //         className="item"
    //       />


    //     </List.Item>
    //   )}
    // />

    <>
      {emails.map((email) => (
        <EmailComponent
          expeditor={email.senderName?? "trinhtam"}
          messageTitle={email.subject}
          message={email.body}
          
        />
      ))}
    </>
  );
};

export default EmailList;