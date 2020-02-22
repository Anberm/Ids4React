import request from '@/utils/request';
import { mgr } from '@/models/global';

export async function query(): Promise<any> {
  return request('/api/users');
}

export async function queryCurrent(): Promise<any> {
  return mgr.getUser();
}

export async function queryNotices(): Promise<any> {
  return request('/api/notices');
}
