import React from "react";


interface Props {
    expeditor:string,
    messageTitle:string,
    message:string,
    timestamp?:string,
  }

const EmailComponent:React.FC<Props> = ({ expeditor, messageTitle, message, timestamp }) => {
  return (
    <div className="flex justify-between border-b py-1.5 px-6 bg-gray-100">
      <p className="w-[8rem] font-bold  "> {expeditor}</p>
      <div className="flex items-center w-[16rem] sm:w-[30rem] truncate   lg:w-[40rem]">
        <p className="font-semibold  ">{messageTitle} -</p>
        <p className="pl-1 text-gray-500 truncate"> {message}</p>
      </div>

      <p className="text-gray-500 w-[6rem] text-end">11/2/2022</p>
    </div>
  );
};

export default EmailComponent;
