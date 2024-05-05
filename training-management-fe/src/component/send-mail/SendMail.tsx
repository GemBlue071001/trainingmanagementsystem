import React, { useState } from 'react';
import { Button, Checkbox, DatePicker, Form, Input } from 'antd';
import { ReactMultiEmail } from 'react-multi-email';
import 'react-multi-email/dist/style.css'
import { Email, EmailRecipient } from '../../model/email/email';
import emailService from '../../services/emailService';
import { log } from 'console';


const SendMail: React.FC = () => {
    const onFinish = async (values: any) => {
        console.log('Success:', values);
        // var toList: EmailRecipient[] = []
        // var ccList: EmailRecipient[] = []
        // var bccList: EmailRecipient[] = []

        // values.toList.forEach((element: any) => {
        //     toList.push({ emailAddress: element })
        // });

        // if (values.ccList !== undefined) {
        //     values.ccList.forEach((element: any) => {
        //         ccList.push({ emailAddress: element })
        //     });
        // }

        // if (values.bccList !== undefined) {
        //     values.bccList.forEach((element: any) => {
        //         bccList.push({ emailAddress: element })
        //     });
        // }
        var email: Email = {
            bccList: values.bccList ?? [],
            ccList: values.ccList ?? [],
            toList: values.toList,
            subject: values.subject,
            body: values.body
        }
        const token = sessionStorage.getItem("token")
        //var token = "EwB4A8l6BAAUAOyDv0l6PcCVu89kmzvqZmkWABkAAWG2oPIqzSU26hNJv5jVHKRzjMocC9JAEGYyJadayKKeukQpR20oCEVT2sskuOFOAbJvrGVDw7OqnF3LsNyi1ZGuExjobtQLqff2oMXMi3YS3NDWTcS00Rp5JYRemGaheO8p971NGBrkkKsPQfAvWsIlPSrIS7REe6fzQQlpHEQTNId9RMf2LJEnp40BzUJTP7VbzCct3AOfryolQTL6j3HPxycrsUCfHei7Gh18O0tDyMlAPLd0Ab+/LAysDkwMury34bgaOzuCvccC3uUuraFPlifmBNCh7h42sR0T3cnUHq5lBHF0D87JCTCpQ5sAUVcDZ/6v4jX6pXWZW4cdyWMDZgAACKFTgXc73X7KSAK8mSQhyiETo81pHC+i7kUqCswmDMAU7DJ/l/yS0nOK8kXNc8xmAaJntA91uD+z8phWs3mOPMFmwVj8yP2YbPDioAv8HS9iMAT8RKLIwYW9QO9oE8+3N1DcKaeU65lwTJpyJb/MsAWm2LmYt2NWVi857UZbiWimt9in78eW3r20W5EXUj97hrXlmDa53e6oKsY4D2+ByVV0hREkcU8W9RVXYO6v/4EcYRkd/Ydi2y7mt8fRGln/f6MonB0nu5gG6uBXCteRYdnK17+MSD4+LK20XE50RnXLkfCnTmpsFnlDNyUuiY9sQYufjBNb2MMuXmHeBMMZfrMuPPwMvWXv6M1D8aonodMfYyBfQhoPlP7tocsPUwUrylM1D0w5hlhztpemyQoRcMUV9jPxCi/Y8msEurf6+SiuWY+pbXiSDJkaXeI0t07BInY1XwRgOqUlzzn0nYghsRLCBG9QG0AY59Ag305SftwFpNgYDpxhdmgAFgkdC8h324pTaRTOBb+VegPjmwUPEWuzDvjkyFTXfOcyodTQqIykZOiXFH2fVHTeSo0T5eqpftvekiSGJU1uMZ3qICGhgpg0bRb7CB/zSoEAWOKPZTtb3l2VSWj8LfYmdZV+k7UVEgeQOtDik/OusAIiRXAvBUMkHUSIQ17Ezb/E9077hTfURiFp3ZSjDhvcPKOrP0E9xNgsD4m2hDRTzZkoPIalifapONoyRCaz6axIIAL59eoN6ZkMr5j51zdFacECyFnkUFDE5BC0X78HQLGruBDTu9z2FYgC"
        //await emailService.sendEmail(email);
    };

    const onSelectDate = (date: any, dateString: string) => {
     console.log(dateString);    
    }

    const onFinishFailed = (errorInfo: any) => {
        console.log('Failed:', errorInfo);
    };
    const [toList, setToList] = useState<string[]>([])
    const [ccList, setCCList] = useState<string[]>([])
    const [bccList, setBCCList] = useState<string[]>([])

    return (
        <Form
            name="basic"
            labelCol={{ span: 8 }}
            wrapperCol={{ span: 16 }}
            style={{ maxWidth: 600 }}
            onFinish={onFinish}
            onFinishFailed={onFinishFailed}
            autoComplete="off">
            <Form.Item
                label="Subject"
                name="subject"
                rules={[{ required: true, message: 'Please input your subject!' }]}>
                <Input />
            </Form.Item>
            {/* To List */}
            <Form.Item
                label="To"
                name="toList"
                rules={[{ required: true, message: 'Please input your recipients!' }]}
            >
                <ReactMultiEmail
                    placeholder="Input your Email Address"
                    emails={toList}
                    onChange={(_emails: string[]) => {
                        setToList(_emails);
                    }}
                    getLabel={(
                        email: string,
                        index: number,
                        removeEmail: (index: number) => void
                    ) => {
                        return (
                            <div data-tag key={index}>
                                {email}
                                <span data-tag-handle onClick={() => removeEmail(index)}>
                                    ×
                                </span>
                            </div>
                        );
                    }}
                />
            </Form.Item>
            {/* CC List */}
            <Form.Item
                label="CC"
                name="ccList"
            >
                <ReactMultiEmail
                    placeholder="Input your Email Address"
                    emails={ccList}
                    onChange={(_emails: string[]) => {
                        setCCList(_emails);
                    }}
                    getLabel={(
                        email: string,
                        index: number,
                        removeEmail: (index: number) => void
                    ) => {
                        return (
                            <div data-tag key={index}>
                                {email}
                                <span data-tag-handle onClick={() => removeEmail(index)}>
                                    ×
                                </span>
                            </div>
                        );
                    }}
                />
            </Form.Item>

            {/* BCC List */}
            <Form.Item
                label="BCC"
                name="bccList"
            >
                <ReactMultiEmail
                    placeholder="Input your Email Address"
                    emails={bccList}
                    onChange={(_emails: string[]) => {
                        setBCCList(_emails);
                    }}
                    getLabel={(
                        email: string,
                        index: number,
                        removeEmail: (index: number) => void
                    ) => {
                        return (
                            <div data-tag key={index}>
                                {email}
                                <span data-tag-handle onClick={() => removeEmail(index)}>
                                    ×
                                </span>
                            </div>
                        );
                    }}
                />
            </Form.Item>

            <Form.Item
                label="Content"
                name="body"
                rules={[{ required: true, message: 'Please input your content!' }]}
            >
                <Input />
            </Form.Item>

            <Form.Item
                label="Sendate"
                name="Sendate"
            >
                <DatePicker onChange={onSelectDate} showTime  />
            </Form.Item>



            <Form.Item wrapperCol={{ offset: 8, span: 16 }}>
                <Button type="primary" htmlType="submit">
                    Submit
                </Button>
            </Form.Item>
        </Form>
    )
};

export default SendMail;