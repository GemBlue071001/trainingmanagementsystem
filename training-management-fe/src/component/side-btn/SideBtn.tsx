import React, { ReactNode } from "react";
import { IconType } from "react-icons/lib";
import { Link } from "react-router-dom";


interface Props {
    title:string,
    icon:ReactNode,
    link:string|undefined
  }

const SideBtn:React.FC<Props> = ({ title, icon ,link}) => {
  return (
    <div className="text-gray-600 flex items-center gap-2">
      {icon}
      <Link to={link!}>{title}</Link>
      {/* <p className="font-semibold">{title}</p> */}
    </div>
  );
};

export default SideBtn;
