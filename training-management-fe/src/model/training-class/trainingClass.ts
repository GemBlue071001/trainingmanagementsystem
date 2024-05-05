import { Pagination } from "../pagination/pagination";

export interface TrainingClass {
    className: string;
    classCode: string;
    classLocation: string | number;
}


export interface TrainingClassPagination {
    pagination: Pagination;
    items: TrainingClass[];
}

export interface TrainingClassResponse {
    statusCode: number;
    isSuccess: boolean;
    errorMessage: string | null;
    result: TrainingClassPagination
}