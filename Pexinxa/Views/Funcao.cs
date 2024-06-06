using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Pexinxa.Views
{
    public class Funcao
    {
        public static string MenuSuperior()
        {
            return @"
            <div id='menusup'>
            <img id='menusup' src='images/logo_icon.png' alt='imagem logo pexinxa'>
            <img id='menusup2' src='images/logotipo.png' alt='imagem logotipo pexinxa '>

            <div id='log_cad_box'>
                <span class='material-symbols-outlined'>Account_Circle</span>
                <p id='log_cad'><a id='log_cad'  data-bs-toggle='modal' data-bs-target='#staticBackdrop'  href='cadastro.html'>cadastre-se</a> ou faça <a id='log_cad' href='#exampleModal' data-bs-toggle='modal'>login</a></p>
            </div>


            <div id='barrapesquisa'>

                <input id='pesquisa' type='text' name='barrapesquisa' placeholder='🔍︎ O que você está procurando?' onkeyup='search()'>
                </input>

            </div>

            <div id='menuinferior2'>
            <ul id='ulmenuinf'>
                <li id='limenuinf2'><a id='menu_inf2' href='Index'><span class='material-symbols-outlined'>home</span>HOME</a></li>
                <li id='limenuinf2'><a id='menu_inf2' href='Produto'><span class='material-symbols-outlined'>Shopping_cart</span>PRODUTOS</a></li>
                <li id='limenuinf2'><a id='menu_inf2' href='Mercado'><span class='material-symbols-outlined'>storefront</span>MERCADOS</a></li>
                <li id='limenuinf2'><a id='menu_inf2' href='Lista'><span class='material-symbols-outlined'>receipt_long</span>LISTA</a></li>
            </ul>
        </div>


            <div id='localizacao'>
            <span class='material-symbols-outlined'>location_on</span><p id='loc'>AV. Judas perdeu as botas, 05 - Matão</p>

                </div>";
        }

        public static string MenuInferior()
        {
            return @"
                 <div id='menuinferior'>
                    <ul id='ulmenuinf'>
                 <li id='limenuinf'><a id='menu_inf' href='index.php'><span class='material-symbols-outlined'>home</span>HOME</a></li>

                 <li id='limenuinf'><a id='menu_inf' href='produtos.php'><span class='material-symbols-outlined'>Shopping_cart</span>PRODUTOS</a></li>

                 <li id='limenuinf'><a id='menu_inf' href='mercado.php'><span class='material-symbols-outlined'>storefront</span>MERCADOS</a></li>

                 <li id='limenuinf'><a id='menu_inf' href='listacompra.php'><span class='material-symbols-outlined'>receipt_long</span>LISTA</a></li>
             </ul>
                 </div>";
        }

        public static string Footer()
        {
            return @"
                <footer>
                    <img width=125px id='logo_footer' src='images/logotipo.png' alt='Logo'><p>Criado por: equipe Pexinxa</p>
                    
                    <div class='social'>
                        <a id='icon_media' href='#'><img src='https://cdn2.iconfinder.com/data/icons/social-networks-18/100/Instagram_logo-256.png' alt='Instagram'></a>
                        <a id='icon_media' href='#'><img src='https://cdn0.iconfinder.com/data/icons/brands-outlined-3/194/facebook-social-network-brand-logo-256.png' alt='Facebook'></a>
                        <a id='icon_media' href='#'><img src='https://cdn4.iconfinder.com/data/icons/social-media-black-white-2/1227/X-256.png' alt='Twitter/ X'></a>
                    </div>
                </footer>";
        }

        // Outras funções podem ser adicionadas aqui

        public static string Produtos(string nomeProduto, string mercado, decimal preco, string img, string imgMercado)
        {
            return $@"
            <div class='produtos' data-name='{nomeProduto}' data-market='{mercado}' data-price='{preco}' id='prod'>
               <img class='img_produto' src="".$img."">
                        
                        <p class='mercado'> <img class='img_mercado' src="".$img_mercado."">"".$mercado."" </p>

                        <p class='desc_prod'>"".$nome_produto.""</p>
                        <p class='preco'>R$ "".$preco.""<span class='material-symbols-outlined'>
                        add_notes
                        </span></p>
            </div>";
        }

        // Outras funções podem ser adicionadas aqui

        public static string ModalCadastro()
        {
            return @"
                 <div class='modal fade' id='staticBackdrop' data-bs-backdrop='static' data-bs-keyboard='false' tabindex='-1' aria-labelledby='staticBackdropLabel' aria-hidden='true'>
                    <div class='modal-dialog modal-xl modal-dialog-scrollable'>
                        <div class='modal-content'>
                          <div class='modal-header'>
                            <h1 class='modal-title fs-5 ' id='staticBackdropLabel'>Cadastre-se</h1>
                            <button type = 'button' class='btn-close' data-bs-dismiss='modal' aria-label='Close'></button>
                          </div>
                          <div class='modal-body'>
                            <div class='form'>
                                <form action = '#' >
                                    < a href='#'>
                                        <img id = 'logo' src='imagens\logo_icon.png' alt='logo pexinxa'>
                                    </a>
                                        <div class='input-group'>
                                            <div class='input-box'>
                                                <label for='firstname'>Primeiro nome</label>
                                                <input type = 'text' id= 'firstname' name= 'firstname' placeholder= 'Digite seu primeiro nome' required minlength = '3' >
                                            </ div >


                                            < div class='input-box'>
                                                <label for='lastname'>Sobrenome</label>
                                                <input type = 'text' id='lastname' name='lastname' placeholder='Digite seu sobrenome' required>
                                            </div>
    
                                            <div class='input-box'>
                                                <label for='cpf'>CPF</label>
                                                <input type = 'text' id='cpf' name='cpf' placeholder='xxxxxxxxxxx' required maxlength = '11' >
                                            </ div >

                                            < div class='input-box'>
                                                <label for='cpf'>CEP</label>
                                                <input type = 'number' id='cep' name='cep' placeholder='xxxxx-xxx' required >
                                            </div>
    
                                            <div class='input-box'>
                                                <label for='nome'>E-mail</label>
                                                <input type = 'text' id='nome' name='nome' placeholder='Digite seu email' >
                                            </div>
    
                                            <div class='input-box'>
                                                <label for='data'>Data Nascimento</label>
                                                <input type = 'text' id= 'data' name= 'data' placeholder= 'dd/mm/aaaa' required maxlength = '11' >
                                            </ div >


                                            < div class='input-box'>
                                                <label for='myPassword'>Senha</label>
                                                <input type = 'password' id='myPassword' name='myPassword' placeholder='Digite sua senha' required>
                                                <div id = 'senha' class='senha2' onclick='PasswordVisibility()'>                 
                                                    <i class='fa fa-eye' id='eye-icon2'></i>
                                                </div>
                                            </div>
    
                                            <div class='input-box1'>
                                                <label for='Confirmpassword'>Confirme sua senha</label>
                                                <input type = 'password' id='Confirmpassword' name='Confirmpassword' placeholder='Confirme sua senha' required>
                                                <div class='csenha' id='senhac' onclick='togglePasswordVisibility()'>
                                                    <i class='fa fa-eye' id='eye-icon'></i>
                                                </div>
                                            </div>
                                        </div>
                                </form>
                            </div>
                          </div>
                          <div class='modal-footer'>
                            <button type = 'button' class='btn btn-danger' data-bs-dismiss='modal'>Fechar</button>
                            <button type = 'submit' class='btn btn-primary'>Cadastrar</button>
                          </div>
                        </div>
                      </div>
                </div>
            <script>
            var passwordInput = document.getElementById('Confirmpassword');
                    var eyeIcon = document.getElementById('eye-icon');

                    function togglePasswordVisibility()
                    {
                        if (passwordInput.type === 'password')
                        {
                            passwordInput.type = 'text';
                            eyeIcon.classList.remove('fa-eye');
                            eyeIcon.classList.add('fa-eye-slash');
                        }
                        else
                        {
                            passwordInput.type = 'password';
                            eyeIcon.classList.remove('fa-eye-slash');
                            eyeIcon.classList.add('fa-eye');
                        }
                    }
                    var passwordInput1 = document.getElementById('myPassword');
                    var eyeIcon1 = document.getElementById('eye-icon2');

                    function PasswordVisibility()
                    {
                        if (passwordInput1.type === 'password')
                        {
                            passwordInput1.type = 'text';
                            eyeIcon1.classList.remove('fa-eye');
                            eyeIcon1.classList.add('fa-eye-slash');
                        }
                        else
                        {
                            passwordInput1.type = 'password';
                            eyeIcon1.classList.remove('fa-eye-slash');
                            eyeIcon1.classList.add('fa-eye');
                        }
                    }
            </script>




            <script src = 'https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js' integrity='sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL' crossorigin='anonymous'></script>'";
        }

        public static string ModalLogin()
        {
            return @"
            <div class='modal fade' id='exampleModal' tabindex='-1' aria-labelledby='exampleModalLabel' aria-hidden='true'>
                 aria-hidden='true'>
                <div class='modal-dialog' role='document'>
                    <div class='modal-content rounded-4 shadow'>
                        <div class='modal-header p-5 pb-4 border-bottom-0'>
                            <img src='images/logo.png' alt='logozin' class='logo' style='height: 60px; width: 60px; margin-right: 20px;'>
                            <h1 class='fw-bold mb-0 fs-2'>Faça seu Login</h1>
                            <button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Close'></button>
                        </div>
    
                        <div class='modal-body p-5 pt-0'>
                            <form class=''>
                                <div class='form-floating mb-3'>
                                    <input type='email' class='form-control rounded-3' id='floatingInput'
                                        placeholder='name@example.com' style='background-color: rgba(128, 128, 128, 0.368);'>
                                    <label for='floatingInput'>E-mail</label>
                                </div>
                                <div class='form-floating mb-3'>
                                    <input type='password' class='form-control rounded-3' id='floatingPassword'
                                        placeholder='Password' style='background-color: rgba(128, 128, 128, 0.368);'>
                                    <label for='floatingPassword'>Senha</label>
                                </div>
                                <button class='btnEntrar' type='submit' style='width: 100%; background-color: rgb(255, 128, 0); border: 0; border-radius: 5px; height: 40px'>Entrar</button>
                                <small class='text-body-secondary'></small>
                                <hr class='my-4'>
                                <h2 class='fs-5 fw-bold mb-3'>Quero acessar com as minhas redes sociais</h2>
                                <button class='w-100 py-2 mb-2 btn btn-outline-secondary rounded-3' type='submit'>
                                    <svg class='bi me-1' width='16' height='16'>
                                        <use xlink:href='#twitter' />
                                    </svg>Fatec
                                </button>
                                <button class='w-100 py-2 mb-2 btn btn-outline-primary rounded-3' type='submit'>
                                    <svg class='bi me-1' width='16' height='16'>
                                        <use xlink:href='#facebook' />
                                    </svg>
                                    Facebook
                                </button>
                                <button class='w-100 py-2 mb-2 btn btn-outline-secondary rounded-3' type='submit'>
                                    <svg class='bi me-1' width='16' height='16'>
                                        <use xlink:href='#github' />
                                    </svg>
                                    GitHub
                            </button>
                        </form>
                    </div>
                </div>
            </div>
            </div>";
        }
    }

}
