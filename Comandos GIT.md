CONFIGURACOES DE USUARIOS
-------------------------------------------------------------------------------
git config --global user.name "Robert Gomes"
-------------------------------------------------------------------------------
git config --global user.email "Seu Email"
-------------------------------------------------------------------------------
git config --global code.editor vscode (no lugar de "vscode" definir seu editor de codigo)
-------------------------------------------------------------------------------
git config --list   (lista configuracoes setadas no seu usuario local)
NAVEGACAO DE PASTAS
-------------------------------------------------------------------------------
cd "pasta ou documento" (documento na pasta atual)
-------------------------------------------------------------------------------
cd ../  (volta um diretorio)
-------------------------------------------------------------------------------
ls (lista documentos do diretorio atual)
-------------------------------------------------------------------------------
dir (lista documentos na pasta atual)
-------------------------------------------------------------------------------
tree /f (cria uma arvore dos arquivos da pasta atual)
-------------------------------------------------------------------------------
mkdir    (cria pasta)
-------------------------------------------------------------------------------
ACOES DO REPOSITORIO
git init    (inicia um repositorio)
-------------------------------------------------------------------------------
git status    (varre a paste e analisa oq acontece)
-------------------------------------------------------------------------------
git add NomeDoArquivoOuPasta (dessa forma adicionamos a pasta ao git, futuros commits)
-------------------------------------------------------------------------------
git add -A     (aplica todas alteracoes para o futuro commit)
-------------------------------------------------------------------------------
git commit -m    (-m seria a mensagem deixada no commit)
-------------------------------------------------------------------------------
git commit -am    ( aplica todas alteracoes e commita)
------------------------------------------------------------------------------
git log     (mostra hitoricos de alteracoes commitadas)
-------------------------------------------------------------------------------
git reset -soft        (vai voltar o estado setado porem antes de commitar)RECOMENDADO
-------------------------------------------------------------------------------
git reset -mixed    (msm coisa do soft porem tem de dar o add novamente)
-------------------------------------------------------------------------------
git reset -hard        (ignora tudo e volta pro estado em que estava na versao selecionada, cagando pro add e commits realizados)
-------------------------------------------------------------------------------
git branch    (lista branchs criadas no nosso repositorio)
-------------------------------------------------------------------------------
git branch NomeDaBranch        (cria uma branch)
-------------------------------------------------------------------------------
git checkout NomedaBranch    (troca para a branch selecionada)
-------------------------------------------------------------------------------
git diff            (mostra todas as alteracoes realizadas em linha)
-------------------------------------------------------------------------------
git diff --name-only        (mostra os arquivos alterados)
-------------------------------------------------------------------------------
git diff nomeDoAruivo        (mostra as alteraoes no arquivo expecifico)
------------------------------------------------------------------------------
REMOTO

git remote add origin https://github.com/rgffn/Projeto-DOTI.git   (adiciona o repositorio local para a remota(nuvem))
------------------------------------------------------------------------------
git remote        (mostra nome do Alias Do Repositorio Remoto )
------------------------------------------------------------------------------
git remote -v        (mostra link dos repositorios remotos e seus alias)
------------------------------------------------------------------------------
git push -u AliasDoRepositorioRemoto branchAserEnviada    (ato que envia do local para remoto)
------------------------------------------------------------------------------
git push AliasDoRepositorioRemoto :NomeDaBranch        (exclui branch remota)
------------------------------------------------------------------------------
git branch -D NomedaBranch    (deleta branch local)
------------------------------------------------------------------------------
.gitignore
------------------------------------------------------------------------------
git revert --no -edit        (volta para o ultimo commit sem excluir as alteracoes feitas do commit atual)
------------------------------------------------------------------------------
git pull AliasDoRepositorioRemoto NomeDaBranch    (puxa todas as atualizacoes do remoto para o local)
------------------------------------------------------------------------------
git clone LinkDoProjeto        (clona o projeto remoto para o ambiente local)